using OOPArv.Animals;

namespace OOPArv.AnimalTypes
{
    public class Plant : Animal
    {
        // Unique attribute of the Plant class and all it's sub classes
        // Protected and encapsulated in the scope of the class (and subclasses)
        protected bool _hasThorns { get; set; }

        /// <summary>
        /// Constructor for the Plant class that assigns new values as defaults if a Plant is created
        /// </summary>
        /// <param name="name">The name of the plant</param>
        /// <param name="species">The species of the plant</param>
        /// <param name="diet">The diet of the plant, lowercase</param>
        /// <param name="age">The the current age of the plant</param>
        /// <param name="isWild">If the plant is wild</param>
        /// <param name="animalType">The type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="hasThorns">If the plant have thorns</param>
        public Plant(
            string name = "Plantan",
            string species = "[]",
            string diet = "jord",
            int age = 5,
            bool isWild = true,
            AnimalType animalType = AnimalType.Plant,
            bool hasThorns = true
        ) : base(name, species, diet, age, isWild, animalType)
        {
            _hasThorns = hasThorns;
        }

        /// <summary>
        /// Writes out the sound a default Plant makes to the console
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{_name} ger ifrån sig ett vistlande ljud då vinden kraftigt skakar alla bladen.");
        }

        /// <summary>
        /// Writes out the default eating habbits of a Plant to the console
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine($"{_name} får sin näring från jorden och energin från soljus genom fotosyntes.");
        }

        /// <summary>
        /// Writes out the default way a Plant adapted to its enviroment for survival to the console
        /// </summary>
        public override void AdaptToEnviroment()
        {
            Console.WriteLine(_hasThorns ? $"{_name} har anpassat sig med taggar för att skydda sig mot faror." :
                                           $"{_name} har anpassat sig med giftiga blad för att skydda sig mot faror.");
        }
    }
}
