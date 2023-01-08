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
    public class Snake : Animal, Reptile
    {
        public Snake(int lifespan, int speed) : base(lifespan, speed)
        {
        }

        public int VenomAmount { get; set; }

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
            if (rand.NextBool(30) && VenomAmount > 10)
            {
                cell.Mammal?.Die();
                cell.deadAnimals.Push(cell.Mammal);
                cell.Mammal = null;
                VenomAmount.SubtractMinTo0(10);
                _blockMovement();
            }
        }

        internal override void Die()
        {
            IsAlive = false;
            CurrentCell.Reptile = null;
            CurrentCell.SetAsDeadAnimal(this);
        }

        internal override void Reproduce()
        {
            Random rand = new Random();
            Optional<Cell> cellOpt = CurrentCell.GetEmptyNeighbourIfExists();
            if (cellOpt.HasValue && rand.NextBool(_parameters.SnakeFertility))
            {
                var cell = cellOpt.Value;
                cell.AddNewbornAnimal(SnakeCreator.GetInstance().create());
            }
        }

        internal override void MetabolicProcesses()
        {
            VenomAmount.AddUpMaxTo100(_parameters.SnakeVenomRegenerationRate);
        }
    }
}
