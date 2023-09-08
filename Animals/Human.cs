using OOPArv.AnimalTypes;

namespace OOPArv.Animals
{
    public class Human : Mammal
    {
        // Unique attribute of the Human class and all it's sub classes
        // Protected and encapsulated in the scope of the class (and subclasses)
        protected bool _socialFobi { get; set; }

        /// <summary>
        /// Constructor for the Human class that assigns new values as defaults if a Human is created
        /// </summary>
        /// <param name="name">The name of the human</param>
        /// <param name="species">The species of the human</param>
        /// <param name="diet">The diet of the human, lowercase</param>
        /// <param name="age">The the current age of the human</param>
        /// <param name="isWild">If the human is wild</param>
        /// <param name="animalType">The type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="furType">Short description of the fur of the human</param>
        /// <param name="socialFobi">If the human have social fobia</param>
        public Human(
            string name = "Människan",
            string species = "[]",
            string diet = "donken",
            int age = 33,
            bool isWild = false,
            AnimalType animalType = AnimalType.Mammal,
            string furType = "flintskallig",
            bool socialFobi = false
        ) : base(name, species, diet, age, isWild, animalType, furType)
        {
            _socialFobi = socialFobi;
        }

        /// <summary>
        /// Writes out the sound a default Human makes to the console
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"Va? Nä inte nu, jag har inte tid.");
        }

        /// <summary>
        /// Writes out the default eating habbits of a Human to the console
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine($"{_name} behöver ät {_diet} för näring, men idag blev det en biltema korv.");
        }

        /// <summary>
        /// Writes out the way a Human adapted to its environment for survival to the console
        /// </summary>
        public override void AdaptToEnvironment()
        {
            Console.WriteLine($"{_name} anpassade miljön runt omkring sig istället för att anpassa sig själv för överlevnad.");
        }

        /// <summary>
        /// Writes out that the human is studying C#
        /// </summary>
        public void Study()
        {
            Console.WriteLine($"{_name} studerar C#.");
        }
    }
}
