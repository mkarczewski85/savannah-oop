using ProjectSavannah.simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.domain
{
    public interface Reptile
    {
        int VenomAmount { get; set; }
        int VenomRegenerationRate { get; set; }

        void Bite(Cell cell);

    }
}
