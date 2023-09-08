using OOPArv.Animals;

namespace OOPArv.AnimalTypes
{
    public class Reptile : Animal
    {
        // Unique attribute of the Reptile class and all it's sub classes
        // Protected and encapsulated in the scope of the class (and subclasses)
        protected bool _hasScales;

        /// <summary>
        /// Constructor for the Reptile class that assigns new values as defaults if a Reptile is created
        /// </summary>
        /// <param name="name">The name of the reptile</param>
        /// <param name="species">The species of the reptile</param>
        /// <param name="diet">The diet of the reptile, lowercase</param>
        /// <param name="age">The the current age of the reptile</param>
        /// <param name="isWild">If the reptile is wild</param>
        /// <param name="animalType">The type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="hasScales">If the reptile have scales or not</param>
        public Reptile(
            string name = "Reptilen",
            string species = "[]",
            string diet = "kött",
            int age = 85,
            bool isWild = true,
            AnimalType animalType = AnimalType.Reptile,
            bool hasScales = true
        ) : base(name, species, diet, age, isWild, animalType)
        {
            _hasScales = hasScales;
        }

        /// <summary>
        /// Writes out the sound a default Reptile makes to the console
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"Hzzzzzzzzzzzzz");
        }

        /// <summary>
        /// Writes out the default eating habbits of a Reptile to the console
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine($"{_name} äter {_diet} för näring.");
        }

        /// <summary>
        /// Writes out the default way a Reptile adapted to its environment for survival to the console
        /// </summary>
        public override void AdaptToEnvironment()
        {
            Console.WriteLine(_hasScales ? $"{_name} har anpassat sig med fjäll för att skydda sig mot andra djur." :
                                           $"{_name} har anpassat sig med giftiga klor eller tänder för att försvara sig mot andra djur.");
        }
    }
}
