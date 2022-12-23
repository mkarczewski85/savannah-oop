using ProjectSavannah.simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain
{
    public class TokoBird : Animal, Bird
    {
        public TokoBird(int x, int y, int lifespan, int speed, World world) : base(x, y, lifespan, speed, world)
        {
        }

        public int FlightHeight { get; set; }
        public int FoodAppetite { get; set; }
        public int CurrentFoodAmount { get; set; }

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
