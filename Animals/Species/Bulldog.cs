namespace OOPArv.Animals.DogRaces
{
    internal class Bulldog : Dog
    {
        // Unique attribute of the Bulldog class and all it's sub classes
        // Protected and encapsulated in the scope of the class (and subclasses)
        protected bool _isDrooling { get; set; }

        /// <summary>
        /// Constructor for the Bulldog class that assigns new values as defaults if a Bulldog is created
        /// </summary>
        /// <param name="name">The name of the bulldog</param>
        /// <param name="species">The species of the bulldog</param>
        /// <param name="diet">The diet of the bulldog, lowercase</param>
        /// <param name="age">The the current age of the bulldog</param>
        /// <param name="isWild">If the bulldog is wild</param>
        /// <param name="animalType">The type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="furType">Short description of the fur of the bulldog</param>
        /// <param name="likesToSleep">If the bulldog likes to sleep</param>
        /// <param name="isDrooling">If the bulldog is drooling</param>
        public Bulldog(
            string name = "Bulldogen",
            string species = "[]",
            string diet = "bullens pilsnerkorv",
            int age = 2,
            bool isWild = true,
            AnimalType animalType = AnimalType.Mammal,
            string furType = "kort och sträv",
            bool likesToSleep = true,
            bool isDrooling = true
        ) : base(name, species, diet, age, isWild, animalType, furType, likesToSleep)
        {
            _isDrooling = isDrooling;
        }
        /// <summary>
        /// Writes out the sound a Bulldog makes to the console
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("WÖFF");
        }

        /// <summary>
        /// Writes out the eating habbits of a Bulldog to the console
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine($"{_name} äter allt möjligt, speciellt när ingen tittar.");
        }

        /// <summary>
        /// Writes out the way a Bulldog adapted to its enviroment for survival to the console
        /// </summary>
        public override void AdaptToEnviroment()
        {
            Console.WriteLine($"{_name} förlitar sig på människan för sin överlevnad.");
        }

        /// <summary>
        /// Writes out that the Bulldog attempts to wiggle its tail
        /// </summary>
        public override void WiggleTail()
        {
            Console.WriteLine($"{_name} försöker vifta på svansen.");
        }

        /// <summary>
        /// Writes out whether the dog is drooling or not
        /// </summary>
        public void Drool()
        {
            if (_isDrooling)
            {
                Console.WriteLine($"{_name} dregglar frenetiskt.");
            }
            else
            {
                Console.WriteLine($"{_name} har slutat dreggla.");
            }
        }
    }
}