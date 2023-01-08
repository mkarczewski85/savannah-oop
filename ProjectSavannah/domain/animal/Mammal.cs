using ProjectSavannah.simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain.animal
{
    public interface Mammal
    {
        int FoodAppetite { get; set; }
        int WaterAppetite { get; set; }
        int CurrentFoodAmount { get; set; }
        int CurrentWaterAmount { get; set; }

        void EatAndDrink();

        static Type GetType()
        {
            return typeof(Mammal);
        }
    }
}
