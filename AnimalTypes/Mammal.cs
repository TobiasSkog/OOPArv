using OOPArv.Animals;

namespace OOPArv.AnimalTypes
{
    public class Mammal : Animal
    {
        // Unique attribute of the Mammal class and all it's sub classes
        // Protected and encapsulated in the scope of the class (and subclasses)
        protected string _furType { get; set; }

        /// <summary>
        /// Constructor for the Mammal class that assigns new values as defaults if a Mammal is created
        /// </summary>
        /// <param name="name">The name of the mammal</param>
        /// <param name="species">The species of the mammal</param>
        /// <param name="diet">The diet of the mammal, lowercase</param>
        /// <param name="age">The the current age of the mammal</param>
        /// <param name="isWild">If the mammal is wild</param>
        /// <param name="animalType">The type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="furType">Short description of the fur of the mammal</param>
        public Mammal(
            string name = "Däggdjuret",
            string species = "[]",
            string diet = "fiskbullar",
            int age = 22,
            bool isWild = true,
            AnimalType animalType = AnimalType.Mammal,
            string furType = "kort och mjukt"
        ) : base(name, species, diet, age, isWild, animalType)
        {
            _furType = furType;
        }

        /// <summary>
        /// Writes out the sound a default Mammal makes to the console
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{_name} Bröööööööööl.");
        }

        /// <summary>
        /// Writes out the default eating habbits of a Mammal to the console
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine($"{_name} äter {_diet} för näring.");
        }

        /// <summary>
        /// Writes out the default way a Mammal adapted to its enviroment to the console
        /// </summary>
        public override void AdaptToEnviroment()
        {
            Console.WriteLine($"{_name} anpassar sig till miljön med {_furType} päls för värme och skydd.");
        }
    }
}


