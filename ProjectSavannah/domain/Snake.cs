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
        public Snake(Cell cell, int lifespan, int speed, World world) : base(cell, lifespan, speed, world)
        {
        }

        public int VenomAmount { get; set; }
        public int VenomRegenerationRate { get; set; }


        internal override void HandleBehavior(Cell cell)
        {
            if (cell.IsEmpty(this))
            {
                UpdatePosition(cell);
                if (cell.IsEmpty(Mammal.GetType()))
                {
                    Bite(cell);
                }
            }
            else _blockMovement();
        }

        internal override void UpdatePosition(Cell newCell)
        {
            var prevCell = CurrentCell;
            prevCell.Reptile = null;
            CurrentCell = newCell;
            newCell.SetAnimal(this);
        }

        public void Bite(Cell cell)
        {
            Random rand = new Random();
            if (rand.NextBool(50))
            {
                cell.Mammal?._kill();
                cell.deadAnimals.Push(cell.Mammal);
                cell.Mammal = null;
                _blockMovement();
            }
        }
    }
}
