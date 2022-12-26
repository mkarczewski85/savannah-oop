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

        public static bool NextBool(this Random random, int truePercentage = 50)
        {
            return random.NextDouble() < truePercentage / 100.0;
        }

        public static T NextItem<T>(this Random random, T[,] array)
        {
            int row = random.Next(array.GetLength(0));
            int column = random.Next(array.GetLength(1));
            return array[row, column];
        }

    }
}
