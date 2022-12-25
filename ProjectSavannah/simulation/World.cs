using ProjectSavannah.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectSavannah.simulation.World;

namespace ProjectSavannah.simulation
{
    public class World
    {

        private cell[,] grid;

        private List<Animal> allAnimals;
        public int xSize { get; private set; }
        public int ySize { get; private set; }

        public World(int xSize, int ySize)
        {
            grid = new cell[xSize, ySize];
            allAnimals = new List<Animal>();
            this.xSize = xSize;
            this.ySize = ySize;
        }

        public struct cell
        {
            public Animal? mammal;
            public Animal? bird;
            public Animal? reptile;
            public Stack<Animal> deadAnimals;
            public int x;
            public int y;

            public cell(int x, int y)
            {
                this.x = x;
                this.y = y;
                mammal = null;
                bird = null;
                reptile = null;
                deadAnimals = new Stack<Animal>();
            }
        }

        public void Initialize() 
        { 
            // TODO
        }

        public void Run() 
        { 
            //TODO
        }

        public cell GetCell(int x, int y) 
        {
            return grid[x,y];
        }

        public bool WithinBoundaries(int x, int y)
        {
            return (x >= 0 && y >= 0 && x < this.xSize && y < this.ySize);
        }

    }
}
