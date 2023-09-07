using OOPArv.AnimalTypes;

namespace OOPArv.Animals
{
    public class Cat : Mammal
    {
        // Unique attribute of the Cat class and all it's sub classes
        // Protected and encapsulated in the scope of the class (and subclasses)
        protected bool _isFriendly { get; set; }

        /// <summary>
        /// Constructor for the Cat class that assigns new values as defaults if a Cat is created
        /// </summary>
        /// <param name="name">The name of the cat</param>
        /// <param name="species">The species of the cat</param>
        /// <param name="diet">The diet of the cat, lowercase</param>
        /// <param name="age">The the current age of the cat</param>
        /// <param name="isWild">If the cat is wild</param>
        /// <param name="animalType">The type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="furType">Short description of the fur of the cat</param>
        /// <param name="isFriendly">If the cat is friendly</param>
        public Cat(
            string name = "Katten",
            string species = "[]",
            string diet = "inte det som serveras",
            int age = 16,
            bool isWild = false,
            AnimalType animalType = AnimalType.Mammal,
            string furType = "lång och mjuk",
            bool isFriendly = true
        ) : base(name, species, diet, age, isWild, animalType, furType)
        {
            _isFriendly = isFriendly;
        }

        /// <summary>
        /// Writes out the sound a default Cat makes to the console
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Mjaooo.");
        }

        /// <summary>
        /// Writes out the default eating habbits of a Cat to the console
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine($"{_name} behöver {_diet} för näring, men föredrar cheez cruncherz och vad det än är som tillreds på spisen.");
        }

        /// <summary>
        /// Writes out the way a Cat adapted to its enviroment for survival to the console
        /// </summary>
        public override void AdaptToEnviroment()
        {
            Console.WriteLine($"{_name} tillåter människan vara i dens närhet för att få tillgång till bättre föda.");
        }

        /// <summary>
        /// Writes out that the Cat is climbing
        /// </summary>
        public void Climb()
        {
            Console.WriteLine($"{_name} klättrar på gardinen.");
        }
    }
}
