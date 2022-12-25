using ProjectSavannah.simulation;
using ProjectSavannah.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain
{
    public class Lion : Animal, Mammal, Predator
    {
        public Lion(int x, int y, int lifespan, int speed, World world) : base(x, y, lifespan, speed, world)
        {
            FoodAppetite = 50;
            WaterAppetite = 50;
            CurrentFoodAmount = 0;
            CurrentWaterAmount = 20;
        }

        public int FoodAppetite { get; set; }
        public int WaterAppetite { get; set; }
        public int CurrentFoodAmount { get; set; }
        public int CurrentWaterAmount { get; set; }

        internal override void HandleBehavior(World.cell cell)
        {
            if (Mammal.IsCellEmpty(cell)) {
                UpdatePosition(cell);
            }
            else _resolveCollision(cell);
        }

        private void _resolveCollision(World.cell cell)
        {
            if (cell.mammal is Predator)
            {
                _blockMovement();
                return; 
            }       
            Hunt(cell);
        }

        internal override void UpdatePosition(World.cell currentCell)
        {
            var prevCell = _world.GetCell(CurrentPosition.x, CurrentPosition.y);
            prevCell.mammal = null;
            CurrentPosition = new position(currentCell.x, currentCell.y);
            currentCell.mammal = this;
        }

        public void Hunt(World.cell cell)
        {
            Random rand = new Random();
            if (rand.NextBool(20))
            {
                cell.mammal?._kill();
                cell.deadAnimals.Add(cell.mammal);
                UpdatePosition(cell);
                _blockMovement();
            }
        }
    }
}
