using ProjectSavannah.simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain
{
    public class Snake : Animal, Reptile
    {
        public Snake(int x, int y, int lifespan, int speed, World world) : base(x, y, lifespan, speed, world)
        {
        }

        public int VenomAmount { get; set; }
        public int VenomRegenerationRate { get; set; }

        public override void Behavior()
        {
            throw new NotImplementedException();
        }

        public override void Handle(World.cell cell)
        {
            throw new NotImplementedException();
        }
    }
}
