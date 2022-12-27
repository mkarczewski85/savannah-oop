using ProjectSavannah.simulation;
using ProjectSavannah.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static ProjectSavannah.domain.animal.Animal;

namespace ProjectSavannah.domain.animal
{
    public abstract class Animal
    {

        public Guid Id { get; private set; }
        public int Age { get; private set; }
        public int Speed { get; private set; }
        public int Lifespan { get; private set; }
        public bool IsAlive { get; private set; }
        internal Cell? CurrentCell;
        private bool _canMove;

        public Animal(int lifespan, int speed)
        {
            Id = Guid.NewGuid();
            Lifespan = lifespan;
            Speed = speed;
            IsAlive = true;
            Age = 0;
            _canMove = true;
        }

        public void Move()
        {
            _enableMovement();
            Console.WriteLine($"{GetType()} {Id} moved to [{CurrentCell.x}][{CurrentCell.y}]");
            var random = new Random();
            Direction randomDirection = random.NextEnum<Direction>();
            for (int i = 0; i < Speed; i++)
            {
                if (CurrentCell.CanMoveTowards(randomDirection) && _canMove)
                {
                    var nextCell = CurrentCell.NextCellFrom(randomDirection);
                    HandleBehavior(nextCell);
                }
                else break;
            }

        }

        internal void _kill() => IsAlive = false;

        internal void _blockMovement() => _canMove = false;

        internal void _enableMovement() => _canMove = true;

        internal abstract void HandleBehavior(Cell cell);

        internal abstract void UpdatePosition(Cell cell);

    }
}
