using ProjectSavannah.domain;
using ProjectSavannah.util;
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

        private Cell[,] _grid;
        public int xSize { get; private set; }
        public int ySize { get; private set; }
        private Random rand = new Random();

        public World(int xSize, int ySize)
        {
            _grid = new Cell[xSize, ySize];
            this.xSize = xSize;
            this.ySize = ySize;
        }

        public Cell GetCell(int x, int y) 
        {
            return _grid[x,y];
        }

        public void AddAnimalAtRandom(Animal animal)
        {
            Cell randomCell;
            do randomCell = rand.NextItem(_grid);
            while (!randomCell.IsEmpty(animal));
        }

        public bool WithinBoundaries(int x, int y)
        {
            return (x >= 0 && y >= 0 && x < xSize && y < ySize);
        }

    }
}
