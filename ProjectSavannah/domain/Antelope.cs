using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain
{
    public class Antelope : Animal, Mammal
    {
        public int FoodAppetite { get; set; }
        public int WaterAppetite { get; set; }
        public int CurrentFoodAmount { get; set; }
        public int CurrentWaterAmount { get; set; }

        public override void Behavior()
        {
            throw new NotImplementedException();
        }
    }
}
