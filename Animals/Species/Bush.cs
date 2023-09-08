using OOPArv.AnimalTypes;

namespace OOPArv.Animals.Species
{
    internal class Bush : Plant
    {
        // Unique attribute of the Bush class and all it's sub classes
        // Protected and encapsulated in the scope of the class (and subclasses)
        protected bool _invasive { get; set; }

        /// <summary>
        /// Constructor for the Bush class that assigns new values as defaults if a Bush is created
        /// </summary>
        /// <param name="name">The name of the bush</param>
        /// <param name="species">The species of the bush</param>
        /// <param name="diet">The diet of the bush, lowercase</param>
        /// <param name="age">The the current age of the bush</param>
        /// <param name="isWild">If the bush is wild</param>
        /// <param name="animalType">The type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="hasThorns">If the bush have thorns</param>
        /// <param name="invasive">If the bush is invasive</param>
        public Bush(
            string name = "Busken",
            string species = "[]",
            string diet = "maskiner",
            int age = 54,
            bool isWild = true,
            AnimalType animalType = AnimalType.Plant,
            bool hasThorns = false,
            bool invasive = false
        ) : base(name, species, diet, age, isWild, animalType, hasThorns)
        {
            _invasive = invasive;
        }

        /// <summary>
        /// Writes out the sound a default Bush makes to the console
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Swooosh.");
        }

        /// <summary>
        /// Writes out the default eating habbits of a Bush to the console
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine($"{_name} får sin näring från jorden och energin från soljus genom fotosyntes.");
        }

        /// <summary>
        /// Writes out the way a Bush adapted to its environment for survival to the console
        /// </summary>
        public override void AdaptToEnvironment()
        {
            Console.WriteLine($"{_name} har tjocka kvistar för att skydda sig mot fara.");
        }

        /// <summary>
        /// Writes out how the Bush grows depending on if it's an invasive species or not
        /// </summary>
        public void Grow()
        {
            if (_invasive)
            {
                Console.WriteLine($"{_name} växer och tar över hela trädgården.");
            }
            else
            {
                Console.WriteLine($"{_name} växer ett nytt blad.");
            }
        }
    }
}