using ProjectSavannah.simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain
{
    public class Antelope : Animal, Mammal
    {
        public Antelope(Cell cell, int lifespan, int speed, World world) : base(cell, lifespan, speed, world)
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
            else _blockMovement();
        }

        internal override void UpdatePosition(Cell newCell)
        {
            var prevCell = CurrentCell;
            prevCell.Mammal = null;
            CurrentCell = newCell;
            newCell.SetAnimal(this);
        }
    }
}
