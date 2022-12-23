using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.util
{
    public static class RandomExtensions
    {
        public static T NextEnum<T>(this Random random)
        {
            var values = Enum.GetValues(typeof(T));
            return (T) values.GetValue(random.Next(values.Length));
        }

        public static bool NextBool(this Random r, int truePercentage = 50)
        {
            return r.NextDouble() < truePercentage / 100.0;
        }

    }
}
