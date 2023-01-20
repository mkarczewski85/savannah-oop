﻿using ProjectSavannah.domain.animal;
using ProjectSavannah.util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.simulation
{
    public class Simulation
    {

        private bool _initialized;
        private bool _paused;
        private double _density;
        public int XSize { get; private set; }
        public int YSize { get; private set; }
        public World? World;
        private Action<string> _eventCallback;


        public Simulation(int xSize, int ySize, int density, Action<string> eventCallback)
        {
            XSize = xSize;
            YSize = ySize;
            _density = density;
            _initialized = false;
            _eventCallback = eventCallback;
        }

        public void Initialize()
        {
            if (World != null) World.Disconnect();
            World = new World(XSize, YSize, _eventCallback);
            var numberOfAnimals = (int)Math.Round(((World.xSize * World.ySize) / 100) * _density);
            Random random = new Random();
            for (int i = 0; i < numberOfAnimals; i++)
            {
                var animal = random.NextAnimal();
                World.AddAnimalAtRandom(animal);
            }
            _initialized = true;
        }

        public void Run()
        {
            _validate(); 
            while (true) 
            {
                Forward();
                if (_paused) break;
                Thread.Sleep(1000);
            }
        }

        public void Forward()
        {
            World.MoveAllAnimals();
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
