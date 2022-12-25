﻿using ProjectSavannah.simulation;
using ProjectSavannah.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        internal readonly World _world;
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
                switch (randomDirection)
                {
                    case Direction.NORTH:
                        newY += -1;
                        break;
                    case Direction.SOUTH:
                        newY += 1;
                        break;
                    case Direction.EAST:
                        newX += 1;
                        break;
                    case Direction.WEST:
                        newX += -1;
                        break;
                }
                if (_world.WithinBoundaries(newX, newY) && _canMove)
                {
                    var nextCell = _world.GetCell((newX), (newY));
                    HandleBehavior(nextCell);
                }
                else break;
            }

        }

        internal void _kill() => IsAlive = false;

        internal void _blockMovement() => _canMove = false;

        internal void _enableMovement() => _canMove = true;

        internal abstract void HandleBehavior(World.cell cell);

        internal abstract void UpdatePosition(World.cell cell);

    }
}
