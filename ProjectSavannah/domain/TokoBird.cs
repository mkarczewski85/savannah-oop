using ProjectSavannah.simulation;
using ProjectSavannah.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain
{
    public class TokoBird : Animal, Bird
    {
        public TokoBird(int x, int y, int lifespan, int speed, World world) : base(x, y, lifespan, speed, world)
        {
        }

        public int FlightHeight { get; set; }
        public int FoodAppetite { get; set; }
        public int CurrentFoodAmount { get; set; }

        internal override void HandleBehavior(World.cell cell)
        {
            if (Bird.IsCellEmpty(cell))
            {
                UpdatePosition(cell);
                if (!Reptile.IsCellEmpty(cell))
                {
                    Catch(cell);
                }
            }
            else _blockMovement();
        }

        internal override void UpdatePosition(World.cell currentCell)
        {
            var prevCell = _world.GetCell(CurrentPosition.x, CurrentPosition.y);
            prevCell.bird = null;
            CurrentPosition = new position(currentCell.x, currentCell.y);
            currentCell.bird = this;
        }

        public void Catch(World.cell cell)
        {
            Random rand = new Random();
            if (rand.NextBool(50))
            {
                cell.reptile?._kill();
                cell.deadAnimals.Push(cell.reptile);
                cell.reptile = null;
                _blockMovement();
            }
        }
    }
}
