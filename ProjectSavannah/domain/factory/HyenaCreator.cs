using ProjectSavannah.domain.animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain.factory
{
    public class HyenaCreator : AnimalCreator
    {
        public Animal create()
        {
            return new Hyena(1200, 2);
        }
    }
}
