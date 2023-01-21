using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.simulation
{
    public sealed class Parameters
    {
        private static Parameters _instance;

        public int LionMaxLifespan { get; set; }
        public int LionMinLifespan { get; set; }

        public int HyenaMaxLifespan { get; set; }
        public int HyenaMinLifespan { get; set; }

        public int AntelopeMaxLifespan { get; set; }
        public int AntelopeMinLifespan { get; set; }

        public int SnakeMaxLifespan { get; set; }
        public int SnakeMinLifespan { get; set; }

        public int TokobirdMaxLifespan { get; set; }
        public int TokobirdMinLifespan { get; set; }

        public double LionFertility { get; set; }
        public double AntelopeFertility { get; set; }
        public double SnakeFertility { get; set; }
        public double HyenaFertility { get; set; }
        public double TokobirdFertility { get; set; }

        public int SnakeVenomRegenerationRate { get; set; }

        public double LionHuntSuccessProbability { get; set; }
        public double TokobirdCatchSuccessProbability { get; set; }
        public double SnakeBiteSuccessProbability { get; set; }

        public int LionMetabolicRate { get; set; }
        public int HyenaMetabolicRate { get; set; }
        public int AntelopeMetabolicRate { get; set; }
        public int TokobirdMetabolicRate { get; set; }

        public int LionDehydrationRate { get; set; }
        public int HyenaDehydrationRate { get; set; }
        public int AntelopeDehydrationRate { get; set; }
        public int TokobirdDehydrationRate { get; set; }

        public double WaterSupplyCoverage { get; set; }
        public double PlantsSupplyCoverage { get; set; }

        private Parameters()
        {
            LionMaxLifespan = Constants.LION_MAX_LIFESPAN;
            LionMinLifespan = Constants.LION_MIN_LIFESPAN;

            HyenaMaxLifespan = Constants.HYENA_MAX_LIFESPAN;
            HyenaMinLifespan = Constants.HYENA_MIN_LIFESPAN;

            AntelopeMaxLifespan = Constants.ANTELOPE_MAX_LIFESPAN;
            AntelopeMinLifespan = Constants.ANTELOPE_MIN_LIFESPAN;

            SnakeMaxLifespan = Constants.SNAKE_MAX_LIFESPAN;
            SnakeMinLifespan = Constants.SNAKE_MIN_LIFESPAN;

            TokobirdMaxLifespan = Constants.TOKOBIRD_MAX_LIFESPAN;
            TokobirdMinLifespan = Constants.TOKOBIRD_MIN_LIFESPAN;

            LionFertility = Constants.LION_FERTILITY;
            AntelopeFertility = Constants.ANTELOPE_FERTILITY;
            SnakeFertility = Constants.SNAKE_FERTILITY;
            HyenaFertility = Constants.HYENA_FERTILITY;
            TokobirdFertility = Constants.TOKOBIRD_FERTILITY;

            SnakeVenomRegenerationRate = Constants.SNAKE_VENOM_REGENERATION_RATE;

            LionHuntSuccessProbability = Constants.LION_HUNT_SUCCESS_PROBABILITY;
            TokobirdCatchSuccessProbability = Constants.TOKOBIRD_CATCH_SUCCESS_PROBABILITY;
            SnakeBiteSuccessProbability = Constants.SNAKE_BITE_SUCCESS_PROBABILITY;

            LionMetabolicRate = Constants.LION_METABOLIC_RATE;
            HyenaMetabolicRate = Constants.HYENA_METABOLIC_RATE;
            AntelopeMetabolicRate = Constants.ANTELOPE_METABOLIC_RATE;
            TokobirdMetabolicRate = Constants.TOKO_BIRD_METABOLIC_RATE;

            LionDehydrationRate = Constants.LION_DEHYDRATION_RATE;
            HyenaDehydrationRate = Constants.HYENA_DEHYDRATION_RATE;
            AntelopeDehydrationRate = Constants.ANTELOPE_DEHYDRATION_RATE;
            TokobirdDehydrationRate = Constants.TOKO_BIRD_DEHYDRATION_RATE;

            WaterSupplyCoverage = Constants.WATER_SUPPLY_COVERAGE;
            PlantsSupplyCoverage = Constants.PLANTS_SUPPLY_COVERAGE;
        }

        public static Parameters GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Parameters();
            }
            return _instance;
        }

    }
}
