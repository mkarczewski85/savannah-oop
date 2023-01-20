using ProjectSavannah.domain.animal;
using ProjectSavannah.simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.util
{
    internal static class EventToDescriptionDict
    {

        private static Dictionary<AnimalEventType, string> _eventDescParts = new Dictionary<AnimalEventType, string>()
        {
            { AnimalEventType.ANIMAL_BIRTH, "Narodziny: "},
            { AnimalEventType.ANIMAL_DEATH, "Śmierć: "},
            { AnimalEventType.HUNT_SUCCESS, "Lew upolował: "},
            { AnimalEventType.CATCH_SUCCESS, "Ptak Toko upolował: "},
            { AnimalEventType.BITE_SUCCESS, "Wąż ukąsił: "}
        };

        private static string _resolveAnimalDescPart(Animal animal)
        {
            string part = animal switch
            {
                Lion _ => "lew",
                Antelope _ => "antylopa",
                Hyena _ => "hiena",
                Snake _ => "wąż",
                TokoBird _ => "ptak Toko",
                _ => "nienznany gatunek",
            };
            return part + " nr " + animal.Id;
        }

        public static string MapToDescription(AnimalEventType eventType, Animal animal)
        {
            return _eventDescParts[eventType] + _resolveAnimalDescPart(animal);
        }
    }
}
