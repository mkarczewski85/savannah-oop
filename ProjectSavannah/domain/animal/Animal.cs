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

    public delegate void AnimalEventHandler(Animal sender, AnimalEventType eventType);

    public abstract class Animal
    {

        public Guid Id { get; private set; }
        public int Age { get; private set; }
        public int Speed { get; private set; }
        public int Lifespan { get; private set; }
        public bool IsAlive { get; internal set; }
        internal Cell? CurrentCell;
        private bool _canMove;
        internal Parameters _parameters;

        public event AnimalEventHandler AnimalEvent;

        public Animal(int lifespan, int speed)
        {
            Id = Guid.NewGuid();
            Lifespan = lifespan;
            Speed = speed;
            IsAlive = true;
            Age = 0;
            _canMove = true;
            _parameters = Parameters.GetInstance();
        }

        public void Move()
        {
            if (!IsAlive) return;
            _enableMovement();
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
            _getOldAndDie();
            MetabolicProcesses();
            Reproduce();
        }

        internal void _blockMovement() => _canMove = false;

        internal void _enableMovement() => _canMove = true;

        internal void _getOldAndDie()
        {
            Age++;
            if (Age > Lifespan) 
            { 
                Die();
            }
        }

        internal void _notifyEvent(AnimalEventType message)
        {
            if (AnimalEvent != null)
            {
                AnimalEvent(this, message);
            }
        }

        internal abstract void Die();

        internal abstract void Reproduce();

        internal abstract void MetabolicProcesses();

        internal abstract void HandleBehavior(Cell cell);

        internal abstract void UpdatePosition(Cell cell);

    }
}
