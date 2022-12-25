﻿using ProjectSavannah.simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain
{
    public class Antelope : Animal, Mammal
    {
        public Antelope(int x, int y, int lifespan, int speed, World world) : base(x, y, lifespan, speed, world)
        {
        }

        public int FoodAppetite { get; set; }
        public int WaterAppetite { get; set; }
        public int CurrentFoodAmount { get; set; }
        public int CurrentWaterAmount { get; set; }

        internal override void HandleBehavior(World.cell cell)
        {
            if (Mammal.IsCellEmpty(cell))
            {
                UpdatePosition(cell);
            }
            else _blockMovement();
        }

        internal override void UpdatePosition(World.cell currentCell)
        {
            var prevCell = _world.GetCell(CurrentPosition.x, CurrentPosition.y);
            prevCell.mammal = null;
            CurrentPosition = new position(currentCell.x, currentCell.y);
            currentCell.mammal = this;
        }
    }
}
