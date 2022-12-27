using ProjectSavannah.domain.animal;
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
        private Random random = new();

        public World(int xSize, int ySize)
        {
            _grid = new Cell[xSize, ySize];
            for (int i = 0; i < _grid.GetLength(0); i++)
            {
                for (int j = 0; j < _grid.GetLength(1); j++)
                {
                    _grid[i, j] = new Cell(i, j, this);
                }
            }
            this.xSize = xSize;
            this.ySize = ySize;
        }

        public Cell GetCell(int x, int y) 
        {
            return _grid[x,y];
        }

        public void AddAnimalAtRandom(Animal animal)
        {
            Cell? randomCell;
            do randomCell = random.NextItem(_grid);
            while (!randomCell.AddAnimalIfEmpty(animal));
        }

        public bool WithinBoundaries(int x, int y)
        {
            return (x >= 0 && y >= 0 && x < xSize && y < ySize);
        }

    }
}
