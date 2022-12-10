using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain
{
    public class Snake : Animal, Reptile
    {
        public int VenomAmount { get; set; }
        public int VenomRegenerationRate { get; set; }

        public override void Behavior()
        {
            throw new NotImplementedException();
        }
    }
}
