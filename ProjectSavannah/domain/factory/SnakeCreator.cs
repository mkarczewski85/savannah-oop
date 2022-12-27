using ProjectSavannah.domain.animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain.factory
{
    public class SnakeCreator : AnimalCreator
    {
        public Animal create()
        {
            return new Snake(2000, 1);
        }
    }
}
