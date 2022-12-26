using ProjectSavannah.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.simulation
{
    public class Cell
    {
        public Animal? Mammal { get; set; }
        public Animal? Bird { get; set; }
        public Animal? Reptile { get; set; }
        public Stack<Animal> deadAnimals;
        public int x;
        public int y;

        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
            Mammal = null;
            Bird = null;
            Reptile = null;
            deadAnimals = new Stack<Animal>();
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
    }
}
}
