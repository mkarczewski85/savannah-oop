using ProjectSavannah.domain.animal;
using ProjectSavannah.domain.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.util
{
    public static class RandomExtensions
    {

        private static Dictionary<AnimalCreator, double> probabilities = new Dictionary<AnimalCreator, double>()
        {
            { new LionCreator(), 0.1 },
            { new AntelopeCreator(), 0.2 },
            { new HyenaCreator(), 0.3 },
            { new SnakeCreator(), 0.2 },
            { new TokoBirdCreator(), 0.2 }
        };

        public static T NextEnum<T>(this Random random)
        {
            var values = Enum.GetValues(typeof(T));
            return (T)values.GetValue(random.Next(values.Length));
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

        public static Animal? NextAnimal(this Random random)
        {
            double r = random.NextDouble();
            AnimalCreator animalCreator = null;
            foreach (var pair in probabilities)
            {
                if (r < pair.Value)
                {
                    animalCreator = pair.Key;
                    break;
                }
                r -= pair.Value;
            }
            return animalCreator?.create();
        }
    }
}
