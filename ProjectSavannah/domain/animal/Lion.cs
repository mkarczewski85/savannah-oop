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
            if (rand.NextBool(20))
            {
                cell.Mammal?._kill();
                cell.deadAnimals.Push(cell.Mammal);
                UpdatePosition(cell);
                _blockMovement();
            }
        }
    }
}
