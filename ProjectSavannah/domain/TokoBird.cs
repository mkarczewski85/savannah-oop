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
        public TokoBird(Cell cell, int lifespan, int speed, World world) : base(cell, lifespan, speed, world)
        {
        }

        public int FlightHeight { get; set; }
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
            if (rand.NextBool(50))
            {
                cell.Reptile?._kill();
                cell.deadAnimals.Push(cell.Reptile);
                cell.Reptile = null;
                _blockMovement();
            }
        }
    }
}
