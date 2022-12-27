using ProjectSavannah.domain.animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain.factory
{
    public class LionCreator : AnimalCreator
    {
        public Animal create()
        {
            return new Lion(1000, 2);
        }
    }
}
