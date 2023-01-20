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
    public class Hyena : Animal, Mammal, Predator
    {
        public Hyena(int lifespan, int speed) : base(lifespan, speed)
        {
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
                if (cell.deadAnimals.TryPop(out var animal))
                {
                    CurrentFoodAmount = CurrentFoodAmount.AddUpMaxTo100(10);
                    FoodAppetite = FoodAppetite.SubtractMinTo0(10);
                }
            }
            else _blockMovement();
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
            throw new NotImplementedException("Hyenas do not hunt!");
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
            Random rand = new();
            Optional<Cell> cellOpt = CurrentCell.GetEmptyNeighbourIfExists();
            if (cellOpt.HasValue && rand.NextBool(_parameters.HyenaFertility))
            {
                var cell = cellOpt.Value;
                cell.AddNewbornAnimal(HyenaCreator.GetInstance().create());
                _notifyEvent(AnimalEventType.ANIMAL_BIRTH);
            }
        }

        internal override void MetabolicProcesses()
        {
            EatAndDrink();
            static bool runOutOf(int appetite, int amount) => appetite == 100 && amount == 0;
            FoodAppetite = FoodAppetite.AddUpMaxTo100(_parameters.HyenaMetabolicRate);
            WaterAppetite = WaterAppetite.AddUpMaxTo100(_parameters.HyenaMetabolicRate);
            CurrentFoodAmount = CurrentFoodAmount.SubtractMinTo0(_parameters.HyenaDehydrationRate);
            CurrentWaterAmount = CurrentWaterAmount.SubtractMinTo0(_parameters.HyenaDehydrationRate);
            if (runOutOf(FoodAppetite, CurrentFoodAmount) ||
                runOutOf(WaterAppetite, CurrentWaterAmount)) Die();
        }

        public void EatAndDrink()
        {
            // hyenas only eats carrion
            if (CurrentCell.HasWaterSupply())
            {
                WaterAppetite = WaterAppetite.SubtractMinTo0(_parameters.HyenaDehydrationRate);
                CurrentWaterAmount = CurrentWaterAmount.AddUpMaxTo100(_parameters.HyenaDehydrationRate);
            }
        }
    }
}
