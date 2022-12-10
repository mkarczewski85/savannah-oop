using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain
{
    public interface Mammal
    {
        int FoodAppetite { get; set; }
        int WaterAppetite { get; set; }
        int CurrentFoodAmount { get; set; }
        int CurrentWaterAmount { get; set; }
    }
}
