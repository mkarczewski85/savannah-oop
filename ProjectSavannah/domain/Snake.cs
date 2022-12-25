using ProjectSavannah.simulation;
using ProjectSavannah.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain
{
    public class Snake : Animal, Reptile
    {
        public Snake(int x, int y, int lifespan, int speed, World world) : base(x, y, lifespan, speed, world)
        {
        }

        public int VenomAmount { get; set; }
        public int VenomRegenerationRate { get; set; }


        internal override void HandleBehavior(World.cell cell)
        {
            if (Reptile.IsCellEmpty(cell))
            {
                UpdatePosition(cell);
                if (!Mammal.IsCellEmpty(cell))
                {
                    Bite(cell);
                }
            }
            else _blockMovement();
        }

        internal override void UpdatePosition(World.cell currentCell)
        {
            var prevCell = _world.GetCell(CurrentPosition.x, CurrentPosition.y);
            prevCell.reptile = null;
            CurrentPosition = new position(currentCell.x, currentCell.y);
            currentCell.reptile = this;
        }

        public void Bite(World.cell cell)
        {
            Random rand = new Random();
            if (rand.NextBool(50))
            {
                cell.mammal?._kill();
                cell.deadAnimals.Add(cell.mammal);
                cell.mammal = null;
                _blockMovement();
            }
        }
    }
}
