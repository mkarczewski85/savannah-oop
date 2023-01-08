using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.util
{
    public static class IntegerExtensions
    {
        public static int AddUpMaxTo100(this int value, int addValue)
        {
            if (value + addValue > 100) return 100;
            return value + addValue;
        }

        public static int SubtractMinTo0(this int value, int subtractValue)
        {
            if (value - subtractValue < 0) return 0;
            return value - subtractValue;
        }
    }
}
