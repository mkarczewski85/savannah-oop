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

        public override void Behavior()
        {
            
            throw new NotImplementedException();
        }

        public override void Handle(World.cell cell)
        {
            if (_cellIsEmpty(cell)) {
                UpdatePosition(cell);
            }
            else _resolveCollision(cell);
        }

        private void _resolveCollision(World.cell cell)
        {
            if (cell.mammal is Predator) return;        
            Hunt(cell);
        }

        private bool _cellIsEmpty(World.cell cell)
        {
            return cell.mammal == null && cell.reptile == null;
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
                cell.deadAnimals.Add(cell.mammal);
                UpdatePosition(cell);
            }
        }
    }
}
