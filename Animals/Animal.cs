namespace OOPArv.Animals
{
    /// <summary>
    /// A public enum that holds the types of Animals that the subclasses of Animal belongs to
    /// </summary>
    public enum AnimalType
    {
        Mammal,
        Reptile,
        Plant
    }

    /// <summary>
    /// Super Class Animal that will be the base for all the subclasses in this project
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// The attributes for the Animal Class are all protected to keep the code encapsulated and
        /// protected so that they cannot be changed outside the scope of the class
        /// </summary>
        protected string _name { get; set; }
        protected string _species { get; set; }
        protected string _diet { get; set; }
        protected int _age { get; set; }
        protected bool _isWild { get; set; }
        protected AnimalType _animalType { get; set; }
        /// <summary>
        /// Constructor for the Animal Super Class used in the assignment
        /// </summary>
        /// <param name="name">string - name of the animal</param>
        /// <param name="species">string - species of the animal</param>
        /// <param name="diet">string - the diet of the animal</param>
        /// <param name="age">int - the current age of the animal</param>
        /// <param name="isWild">bool - if the animal is wild</param>
        /// <param name="animalType">enum - type of animal (Mammal, Reptile, Plant)</param>
        public Animal(string name, string species, string diet, int age, bool isWild, AnimalType animalType)
        {
            _name = name;
            _species = species;
            _diet = diet;
            _age = age;
            _isWild = isWild;
            _animalType = animalType;
        }
        /// <summary>
        /// Writes out to the console the name of the animal what spieces they are and what age
        /// </summary>
        public void Introduction()
        {
            Console.WriteLine($"{_name} är en {_species} på {_age} år.");
        }
        /// <summary>
        /// abstract method that all subclasses have to implement that 
        /// will write out the sound the animal make to the console
        /// </summary>
        public abstract void MakeSound();
        /// <summary>
        /// abstract method that all subclasses have to implement that 
        /// will write out what the animal eats
        /// </summary>
        public abstract void Eat();
        /// <summary>
        /// abstract method that all subclasses have to implement that 
        /// will write out how the animal adapted to its envirement
        /// </summary>
        public abstract void AdaptToEnviroment();
    }
}
