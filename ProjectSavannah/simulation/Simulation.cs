using ProjectSavannah.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.simulation
{
    internal class Simulation
    {

        private bool _initialized;
        private bool _paused;
        private World _world;
        private List<Animal> _allAnimals;


        public Simulation(int xSize, int ySize)
        {
            _allAnimals = new List<Animal>();
            _world = new World(xSize, ySize);
            _initialized = false;
        }

        public void Initialize()
        {
            // TODO

            _initialized = true;
        }

        public void Run()
        {
            //TODO
            _validate(); 
            while (true) 
            {
                // TODO
                if (_paused) break;
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
            // TODO
        }

        private void _validate()
        {
            if (_initialized) return;
            throw new InvalidOperationException("Simulation must be initialized");
        }

    }
}
