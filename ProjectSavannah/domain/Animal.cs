using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain
{
    public abstract class Animal
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public int Speed { get; set; }

        public abstract void Behavior();
    }
}
