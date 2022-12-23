using ProjectSavannah.simulation;
using ProjectSavannah.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectSavannah.domain.Animal;

namespace ProjectSavannah.domain
{
    public abstract class Animal
    {

        public Guid Id { get; private set; }
        public int Age { get; private set; }
        public int Speed { get; private set; }
        public int Lifespan { get; private set; }
        public bool IsAlive { get; private set; }
        public position CurrentPosition { get; set; }
        private readonly World _world;
        private bool _canMove;

        public Animal(int x, int y, int lifespan, int speed, World world)
        {
            Id = Guid.NewGuid();
            CurrentPosition = new position(x, y);
            Lifespan = lifespan;
            Speed = speed;
            IsAlive = true;
            Age = 0;
            _world = world;
            _canMove = true;
        }

        public struct position
        {
            public int x { get; set; }
            public int y { get; set; }

            public position(int x, int y)
            {
                this.x = x;
                this.y = y; 
            }
        }

        public enum Direction
        {
            NORTH,
            SOUTH,
            EAST,
            WEST
        }

        public void Move()
        {
            _enableMovement();
            var random = new Random();
            Direction randomDirection = random.NextEnum<Direction>();
            int newX = CurrentPosition.x;
            int newY = CurrentPosition.y;
            for (int i = 1; i <= Speed; i++) 
            {
                int dx = 0;
                int dy = 0;
                switch (randomDirection)
                {
                    case Direction.NORTH:
                        dy = -1;
                        break;
                    case Direction.SOUTH:
                        dy = 1;
                        break;
                    case Direction.EAST:
                        dx = 1;
                        break;
                    case Direction.WEST:
                        dx = -1;
                        break;
                }
                if (_world.WithinBoundaries(newX + dx, newY + dy) && _canMove)
                {
                    var nextCell = _world.GetCell((newX + dx), (newY + dy));
                    Handle(nextCell);
                }
                else
                {
                    _blockMovement();
                    break;
                } 
            }

        }

        internal void _blockMovement() => _canMove = false;

        internal void _enableMovement() => _canMove = true;

        public abstract void Behavior();

        public abstract void Handle(World.cell cell);
    }
}
