using ProjectSavannah.simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain
{
    public interface Bird
    {
        int FlightHeight { get; set; }
        int FoodAppetite { get; set; }
        int CurrentFoodAmount { get; set; }

        void Catch(Cell cell);

    }
}
