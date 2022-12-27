using ProjectSavannah.domain.animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain.factory
{
    public class AntelopeCreator : AnimalCreator
    {
        public Animal create()
        {
            return new Antelope(1500, 1);
        }
    }
}
