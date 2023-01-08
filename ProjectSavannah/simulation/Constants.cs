using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.simulation
{
    public static class Constants
    {
        public const int LION_SPEED = 2;
        public const int HYENA_SPEED = 1;
        public const int ANTELOPE_SPEED = 1;
        public const int SNAKE_SPEED = 1;
        public const int TOKOBIRD_SPEED = 2;

        public const int LION_MAX_LIFESPAN = 600;
        public const int LION_MIN_LIFESPAN = 300;

        public const int HYENA_MAX_LIFESPAN = 700;
        public const int HYENA_MIN_LIFESPAN = 500;

        public const int ANTELOPE_MAX_LIFESPAN = 1000;
        public const int ANTELOPE_MIN_LIFESPAN = 600;

        public const int SNAKE_MAX_LIFESPAN = 2000;
        public const int SNAKE_MIN_LIFESPAN = 1000;

        public const int TOKOBIRD_MAX_LIFESPAN = 1500;
        public const int TOKOBIRD_MIN_LIFESPAN = 1000;

        public const double LION_FERTILITY = 0.02;
        public const double ANTELOPE_FERTILITY = 0.15;
        public const double SNAKE_FERTILITY = 0.01;
        public const double HYENA_FERTILITY = 0.04;
        public const double TOKOBIRD_FERTILITY = 0.01;

        public const double WORLD_WATER_SUPPLY = 0.7;
        public const double WORLD_PLANTS_SUPPLY = 0.5;

        public const int SNAKE_VENOM_REGENERATION_RATE = 1;

        public const double TOKOBIRD_FLIGHT_ALTITUDE = 200;

        public const double LION_HUNT_SUCCESS_PROBABILITY = 0.4;
        public const double TOKOBIRD_CATCH_SUCCESS_PROBABILITY = 0.2;
        public const double SNAKE_BITE_SUCCESS_PROBABILITY = 0.1;

        public const int LION_METABOLIC_RATE = 10;
        public const int HYENA_METABOLIC_RATE = 5;
        public const int ANTELOPE_METABOLIC_RATE = 10;
        public const int TOKO_BIRD_METABOLIC_RATE = 5;

        public const int LION_DEHYDRATION_RATE = 1;
        public const int HYENA_DEHYDRATION_RATE = 1;
        public const int ANTELOPE_DEHYDRATION_RATE = 1;
        public const int TOKO_BIRD_DEHYDRATION_RATE = 1;

        public const double WATER_SUPPLY_COVERAGE = 0.5;
        public const double PLANTS_SUPPLY_COVERAGE = 0.5;

    }
}
