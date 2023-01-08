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
    public class Antelope : Animal, Mammal
    {
        public Antelope(int lifespan, int speed) : base(lifespan, speed)
        {
            FoodAppetite = 50;
            WaterAppetite = 50;
            CurrentFoodAmount = 50;
            CurrentWaterAmount = 50;
        }

        public int FoodAppetite { get; set; }
        public int WaterAppetite { get; set; }
        public int CurrentFoodAmount { get; set; }
        public int CurrentWaterAmount { get; set; }


        internal override void HandleBehavior(Cell cell)
        {
            if (cell.IsEmpty(this))
            {
                UpdatePosition(cell);
            }
            else _blockMovement();
        }

        internal override void Die()
        {
            IsAlive = false;
            CurrentCell.Mammal = null;
            CurrentCell.SetAsDeadAnimal(this);
        }

        internal override void UpdatePosition(Cell newCell)
        {
            var prevCell = CurrentCell;
            prevCell.Mammal = null;
            CurrentCell = newCell;
            newCell.SetAnimal(this);
        }

        internal override void Reproduce()
        {
            Random rand = new Random();
            Optional<Cell> cellOpt = CurrentCell.GetEmptyNeighbourIfExists();
            if (cellOpt.HasValue && rand.NextBool(_parameters.AntelopeFertility))
            {
                var cell = cellOpt.Value;
                cell.AddNewbornAnimal(AntelopeCreator.GetInstance().create());
            }
        }

        internal override void MetabolicProcesses()
        {
            EatAndDrink();
            static bool runOutOf(int appetite, int amount) => appetite == 100 && amount == 0;
            FoodAppetite = FoodAppetite.AddUpMaxTo100(_parameters.AntelopeMetabolicRate);
            WaterAppetite = WaterAppetite.AddUpMaxTo100(_parameters.AntelopeMetabolicRate);
            CurrentFoodAmount = CurrentFoodAmount.SubtractMinTo0(_parameters.AntelopeMetabolicRate);
            CurrentWaterAmount = CurrentWaterAmount.SubtractMinTo0(_parameters.AntelopeMetabolicRate);
            if (runOutOf(FoodAppetite, CurrentFoodAmount) ||
                runOutOf(WaterAppetite, CurrentWaterAmount)) Die();
        }

        public void EatAndDrink()
        {
            if (CurrentCell.HasWaterSupply())
            {
                WaterAppetite = WaterAppetite.SubtractMinTo0(_parameters.AntelopeMetabolicRate);
                CurrentWaterAmount = CurrentWaterAmount.AddUpMaxTo100(_parameters.AntelopeMetabolicRate);
            }
            // antelopes eats plants
            if (CurrentCell.HasPlantsSupply())
            {
                FoodAppetite = FoodAppetite.SubtractMinTo0(_parameters.AntelopeMetabolicRate);
                CurrentFoodAmount = CurrentFoodAmount.AddUpMaxTo100(_parameters.AntelopeMetabolicRate);
            }
        }
    }
}
