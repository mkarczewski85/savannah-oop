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
    public class Lion : Animal, Mammal, Predator
    {
        public Lion(int lifespan, int speed) : base(lifespan, speed)
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
            else _resolveCollision(cell);
        }

        private void _resolveCollision(Cell cell)
        {
            if (cell.Mammal is Predator)
            {
                _blockMovement();
                return;
            }
            Hunt(cell);
        }

        internal override void UpdatePosition(Cell newCell)
        {
            var prevCell = CurrentCell;
            prevCell.Mammal = null;
            CurrentCell = newCell;
            newCell.SetAnimal(this);
        }

        public void Hunt(Cell cell)
        {
            Random rand = new Random();
            if (CurrentFoodAmount < FoodAppetite && rand.NextBool(_parameters.LionHuntSuccessProbability))
            {
                cell.Mammal?.Die();
                cell.deadAnimals.Push(cell.Mammal);
                UpdatePosition(cell);
                _blockMovement();
                CurrentFoodAmount = CurrentFoodAmount.AddUpMaxTo100(10);
                FoodAppetite = FoodAppetite.SubtractMinTo0(10);
                _notifyEvent(AnimalEventType.HUNT_SUCCESS);
            }
        }

        internal override void Die()
        {
            IsAlive = false;
            CurrentCell.Mammal = null;
            CurrentCell.SetAsDeadAnimal(this);
            _notifyEvent(AnimalEventType.ANIMAL_DEATH);
        }

        internal override void Reproduce()
        {
            Random rand = new ();
            Optional<Cell> cellOpt =  CurrentCell.GetEmptyNeighbourIfExists();
            if (cellOpt.HasValue && rand.NextBool(_parameters.LionFertility))
            {
                var cell = cellOpt.Value;
                cell.AddNewbornAnimal(LionCreator.GetInstance().create());
                _notifyEvent(AnimalEventType.ANIMAL_BIRTH);
            }
        }

        internal override void MetabolicProcesses()
        {
            EatAndDrink();
            static bool runOutOf(int appetite, int amount) => appetite == 100 && amount == 0;
            FoodAppetite = FoodAppetite.AddUpMaxTo100(_parameters.LionMetabolicRate);
            WaterAppetite = WaterAppetite.AddUpMaxTo100(_parameters.LionMetabolicRate);
            CurrentFoodAmount = CurrentFoodAmount.SubtractMinTo0(_parameters.LionDehydrationRate);
            CurrentWaterAmount = CurrentWaterAmount.SubtractMinTo0(_parameters.LionDehydrationRate);
            if (runOutOf(FoodAppetite, CurrentFoodAmount) || 
                runOutOf(WaterAppetite, CurrentWaterAmount)) Die();
           
        }

        public void EatAndDrink()
        {
            // lions only eats meat
            if (CurrentCell.HasWaterSupply())
            { 
                WaterAppetite = WaterAppetite.SubtractMinTo0(_parameters.LionMetabolicRate);
                CurrentWaterAmount = CurrentWaterAmount.AddUpMaxTo100(_parameters.LionMetabolicRate);
            }
        }
    }
}
