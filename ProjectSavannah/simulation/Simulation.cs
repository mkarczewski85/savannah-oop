using ProjectSavannah.domain.animal;
using ProjectSavannah.util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.simulation
{
    internal class Simulation
    {

        private bool _initialized;
        private bool _paused;
        private double _fillPercentage;
        private int _xSize;
        private int _ySize;
        private World? _world;
        private List<Animal>? _allAnimals;


        public Simulation(int xSize = 100, int ySize = 100, double fillPercentage = 0.2)
        {
            _xSize = xSize;
            _ySize = ySize;
            _fillPercentage = fillPercentage;
            _initialized = false;
            
        }

        public void Initialize()
        {
            _world = new World(_xSize, _ySize);
            _allAnimals = new List<Animal>();
            var numberOfAnimals = (int)Math.Round(((_world.xSize * _world.ySize) / 100) * _fillPercentage);
            Random random = new Random();
            for (int i = 0; i < numberOfAnimals; i++)
            {
                var animal = random.NextAnimal();
                _world.AddAnimalAtRandom(animal);
                _allAnimals.Add(animal);
            }
            _initialized = true;
        }

        public void Run()
        {
            _validate(); 
            while (true) 
            {
                _allAnimals.ForEach(animal => animal.Move());
                if (_paused) break;
                Thread.Sleep(1000);
            }
        }

        public void Stop()
        {
            _validate();
            _paused = true;
        }

        public void Reset()
        {
            _validate();
            Stop();
            Initialize();
        }


        private void _validate()
        {
            if (_initialized) return;
            throw new InvalidOperationException("Simulation must be initialized");
        }

    }
}
