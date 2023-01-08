using ProjectSavannah.domain.animal;
using ProjectSavannah.domain.artefacts;
using ProjectSavannah.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectSavannah.domain.animal.Animal;

namespace ProjectSavannah.simulation
{
    public class Cell
    {
        public Animal? Mammal { get; set; }
        public Animal? Bird { get; set; }
        public Animal? Reptile { get; set; }
        public Stack<Animal> deadAnimals;
        public WaterSupply? WaterSupply { get; set; }
        public PlantsSupply? PlantsSupply { get; set; }
        private World _world;
        public int x;
        public int y;

        public Cell(int x, int y, World world)
        {
            this.x = x;
            this.y = y;
            Mammal = null;
            Bird = null;
            Reptile = null;
            deadAnimals = new Stack<Animal>();
            _world = world;
            _supplyWithWaterAndPlants();
        }

        public bool AddAnimalIfEmpty(Animal animal)
        {
            if (IsEmpty(animal))
            {
                SetAnimal(animal);
                return true;
            }
            return false;
        }

        public bool IsEmpty(Animal animal)
        {
            switch (animal)
            {
                case Mammal _: return Mammal == null;
                case Bird _: return Bird == null;
                case Reptile _: return Reptile == null;
                default: return false;
            }
        }

        public bool IsEmpty(Type animal)
        {
            switch (animal)
            {
                case Mammal _: return Mammal == null;
                case Bird _: return Bird == null;
                case Reptile _: return Reptile == null;
                default: return false;
            }
        }

        public bool IsEmpty()
        { 
            return Mammal == null && Bird == null && Reptile == null;
        }

        public void SetAnimal(Animal animal)
        {
            switch (animal)
            {
                case Mammal _: Mammal = animal; break;
                case Bird _: Bird = animal; break;
                case Reptile _: Reptile = animal; break;
            }
            animal.CurrentCell = this;
        }

        public void SetAsDeadAnimal(Animal animal)
        {
            deadAnimals.Push(animal);
        }

        public bool CanMoveTowards(Direction direction) 
        {
            var deltas = _calculateXYDelta(direction);
            return _world.WithinBoundaries(deltas.Item1, deltas.Item2);
        }

        public Cell NextCellFrom(Direction direction)
        {

            var deltas = _calculateXYDelta(direction);
            return _world.GetCell(deltas.Item1, deltas.Item2);
        }

        public Optional<Cell> GetEmptyNeighbourIfExists()
        {
            foreach (Direction direction in Enum.GetValues(typeof(Direction)))
            {
                if (CanMoveTowards(direction)) return Optional<Cell>.Of(NextCellFrom(direction));
            }
            return Optional<Cell>.Empty();
        }

        public void AddNewbornAnimal(Animal animal)
        {
            SetAnimal(animal);
            _world.AddAnimalToList(animal);
        }

        public bool HasWaterSupply()
        {
            return WaterSupply != null;
        }

        public bool HasPlantsSupply()
        { 
            return PlantsSupply != null;
        }

        private Tuple<int, int> _calculateXYDelta(Direction direction)
        {
            int newX = x;
            int newY = y;
            switch (direction)
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
            return Tuple.Create(newX, newY);
        }

        private void _supplyWithWaterAndPlants()
        {
            Random random = new();
            var parameters = Parameters.GetInstance();
            if (random.NextBool(parameters.WaterSupplyCoverage))
            {
                WaterSupply = new();
            }
            if (random.NextBool(parameters.PlantsSupplyCoverage))
            {
                PlantsSupply = new();
            }
        }
    }
}

