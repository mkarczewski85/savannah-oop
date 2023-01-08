using ProjectSavannah.domain.animal;
using ProjectSavannah.simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain.factory
{
    public sealed class HyenaCreator : AnimalCreator
    {
        private readonly Parameters _parameters = Parameters.GetInstance();
        private readonly Random _random = new();
        private static AnimalCreator _instance;

        private HyenaCreator()
        {
        }

        public Animal create()
        {
            var lifespan = _random.Next(_parameters.HyenaMinLifespan, _parameters.HyenaMaxLifespan);
            return new Hyena(lifespan, 2);
        }

        public static AnimalCreator GetInstance()
        {
            if (_instance == null)
            {
                _instance = new HyenaCreator();
            }
            return _instance;
        }


    }
}
