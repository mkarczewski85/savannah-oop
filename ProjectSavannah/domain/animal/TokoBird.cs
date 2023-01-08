using ProjectSavannah.domain.factory;
using ProjectSavannah.simulation;
using ProjectSavannah.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain.animal
{
    public class TokoBird : Animal, Bird
    {
        public TokoBird(int lifespan, int speed) : base(lifespan, speed)
        {
        }

        public int FlightAltitude { get; set; }
        public int FoodAppetite { get; set; }
        public int CurrentFoodAmount { get; set; }

        internal override void HandleBehavior(Cell cell)
        {
            if (cell.IsEmpty(this))
            {
                UpdatePosition(cell);
                if (!cell.IsEmpty(Reptile.GetType()))
                {
                    Catch(cell);
                }
            }
            else _blockMovement();
        }

        internal override void UpdatePosition(Cell newCell)
        {
            var prevCell = CurrentCell;
            prevCell.Bird = null;
            CurrentCell = newCell;
            newCell.SetAnimal(this);
        }

        public void Catch(Cell cell)
        {
            Random rand = new Random();
            if (CurrentFoodAmount < FoodAppetite && rand.NextBool(_parameters.TokobirdCatchSuccessProbability))
            {
                cell.Reptile?.Die();
                cell.deadAnimals.Push(cell.Reptile);
                cell.Reptile = null;
                FoodAppetite = FoodAppetite.SubtractMinTo0(10);
                CurrentFoodAmount = CurrentFoodAmount.AddUpMaxTo100(10);
                _blockMovement();
            }
        }

        internal override void Die()
        {
            IsAlive = false;
            CurrentCell.Bird = null;
            CurrentCell.SetAsDeadAnimal(this);
        }

        internal override void Reproduce()
        {
            Random rand = new();
            Optional<Cell> cellOpt = CurrentCell.GetEmptyNeighbourIfExists();
            if (cellOpt.HasValue && rand.NextBool(_parameters.TokobirdFertility))
            {
                var cell = cellOpt.Value;
                cell.AddNewbornAnimal(TokoBirdCreator.GetInstance().create());
            }
        }

        internal override void MetabolicProcesses()
        {
            static bool runOutOf(int appetite, int amount) => appetite == 100 && amount == 0;
            FoodAppetite = FoodAppetite.AddUpMaxTo100(_parameters.LionMetabolicRate);
            CurrentFoodAmount = CurrentFoodAmount.SubtractMinTo0(_parameters.LionMetabolicRate);
            if (runOutOf(FoodAppetite, CurrentFoodAmount)) Die();
        }
    }
}
