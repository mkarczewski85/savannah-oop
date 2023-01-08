using ProjectSavannah.domain.animal;
using ProjectSavannah.simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain.factory
{
    public sealed class TokoBirdCreator : AnimalCreator
    {
        private readonly Parameters _parameters = Parameters.GetInstance();
        private readonly Random _random = new();
        private static AnimalCreator _instance;

        private TokoBirdCreator()
        {
        }

        public Animal create()
        {
            var lifespan = _random.Next(_parameters.TokobirdMinLifespan, _parameters.TokobirdMaxLifespan);
            return new TokoBird(lifespan, 2);
        }

        public static AnimalCreator GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TokoBirdCreator();
            }
            return _instance;
        }
    }
}
