using OOPArv.AnimalTypes;

namespace OOPArv.Animals
{
    public class Turtle : Reptile
    {
        // Unique attribute of the Turtle class and all it's sub classes
        // Protected and encapsulated in the scope of the class (and subclasses)
        protected string _neckRetraction { get; set; }

        /// <summary>
        /// Constructor for the Turtle class that assigns new values as defaults if a Turtle is created
        /// </summary>
        /// <param name="name">The name of the turtle</param>
        /// <param name="species">The species of the turtle</param>
        /// <param name="diet">The diet of the turtle, lowercase</param>
        /// <param name="age">The the current age of the turtle</param>
        /// <param name="isWild">If the turtle is wild</param>
        /// <param name="animalType">The type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="hasScales">If the turtle have scales or not</param>
        /// <param name="neckRetraction">The kind of neck retraction the turtle have</param>
        public Turtle(
            string name = "Sköldpaddan",
            string species = "[]",
            string diet = "kottar",
            int age = 85,
            bool isWild = true,
            AnimalType animalType = AnimalType.Reptile,
            bool hasScales = true,
            string neckRetraction = "Cryptodira"
        ) : base(name, species, diet, age, isWild, animalType, hasScales)
        {
            _neckRetraction = neckRetraction;
        }

        /// <summary>
        /// Writes out the sound a default Turtle makes to the console
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"hhhssssss");
        }

        /// <summary>
        /// Writes out the default eating habbits of a Turtle to the console
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine($"{_name} äter {_diet} för näring.");
        }

        /// <summary>
        /// Writes out the way a Turtle adapted to its environment for survival to the console
        /// </summary>
        public override void AdaptToEnvironment()
        {
            Console.WriteLine($"{_name} har ett starkt skal för att skydda sig mot faror.");
        }

        /// <summary>
        /// Writes out that the Turtle runs for cover
        /// </summary>
        public void RunAway()
        {
            Console.WriteLine($"{_name} springer iväg och gömmer sig.");
        }
    }
}
