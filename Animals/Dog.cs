using OOPArv.AnimalTypes;

namespace OOPArv.Animals
{
    public class Dog : Mammal
    {
        // Unique attribute of the Dog class and all it's sub classes
        // Protected and encapsulated in the scope of the class (and subclasses)
        protected bool _likesToSleep { get; set; }
        /// <summary>
        /// Constructor for the Dog class that assigns new values as defaults if a Dog is created
        /// </summary>
        /// <param name="name">The name of the dog</param>
        /// <param name="species">The species of the dog</param>
        /// <param name="diet">The diet of the dog, lowercase</param>
        /// <param name="age">The the current age of the dog</param>
        /// <param name="isWild">If the dog is wild</param>
        /// <param name="animalType">The type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="furType">Short description of the fur of the dog</param>
        /// <param name="likesToSleep">If the dog likes to sleep</param>
        public Dog(
            string name = "Hunden",
            string species = "[]",
            string diet = "torrfoder",
            int age = 5,
            bool isWild = false,
            AnimalType animalType = AnimalType.Mammal,
            string furType = "lång och mjukt",
            bool likesToSleep = true
        ) : base(name, species, diet, age, isWild, animalType, furType)
        {
            _likesToSleep = likesToSleep;
        }
        /// <summary>
        /// Writes out the sound a default Dog makes to the console
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Woff");
        }
        /// <summary>
        /// Writes out the default eating habbits of a Dog to the console
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine($"{_name} äter allt.");
        }
        /// <summary>
        /// Writes out the default way a Dog adapted to its environment for survival to the console
        /// </summary>
        public override void AdaptToEnvironment()
        {
            Console.WriteLine($"{_name} förlitar sig på människan för sin överlevnad.");
        }

        /// <summary>
        /// Writes out that Dog is wiggling it's tail
        /// </summary>
        public virtual void WiggleTail()
        {
            Console.WriteLine($"{_name} viftar på svansen.");
        }
    }
}
