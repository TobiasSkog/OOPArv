using OOPArv.Animals.Interfaces;

namespace OOPArv.Animals
{
    /// <summary>
    /// A public enum that holds the types of Animals that the subclasses of Animal belongs to
    /// </summary>
    public enum AnimalType
    {
        Unassigned = -1,
        Mammal = 0,
        Reptile = 1,
        Plant = 2
    }

    /// <summary>
    /// Abstract Super Class Animal that all the subclasses in this project will inherit
    /// </summary>
    public abstract class Animal : IAnimal
    {
        // Default attribute of the Animal class and all it's sub classes
        // Protected and encapsulated in the scope of the class (and subclasses)
        protected string _name { get; set; }
        protected string _species { get; set; }
        protected string _diet { get; set; }
        protected int _age { get; set; }
        protected bool _isWild { get; set; }
        protected AnimalType _animalType { get; set; }

        /// <summary>
        /// Constructor that assigns default values to the class if its not given an input
        /// </summary>
        /// <param name="name">The name of the animal</param>
        /// <param name="species">The species of the animal</param>
        /// <param name="diet">The diet of the animal, lowercase</param>
        /// <param name="age">The current age of the animal</param>
        /// <param name="isWild">If the animal is wild</param>
        /// <param name="animalType">Type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        public Animal(
            string name = "Djuret",
            string species = "[]",
            string diet = "Mums-Mums",
            int age = 42,
            bool isWild = true,
            AnimalType animalType = AnimalType.Unassigned
        )
        {
            _name = name;
            _diet = diet;
            _age = age;
            _isWild = isWild;
            _animalType = animalType;
            _species = GetAnimalType(_animalType, species);
        }

        /// <summary>
        /// Writes out to the console the name, species and age of the Animal
        /// Stringinterpolation output based on _species variable
        /// Could use GetAnimalType method to assign the values to _species directly
        /// But this way we can play around with the code and have fun
        /// </summary>
        public void Introduction()
        {
            Console.WriteLine($"{_name} är {_species switch
            {
                "Unassigned Spieces" => "ett odefinerat djur",
                "Mammal" => "ett däggdjur",
                "Reptile" => "en reptil",
                "Plant" => "en planta",
                _ => _species
            }} på {_age} år.");
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
        /// will write out how the animal adapted to its envirement for survival 
        /// </summary>
        public abstract void AdaptToEnvironment();

        /// <summary>
        /// If the _species attribute is left to default values in assignment this method
        /// will assign a default value to _species depending on what animalType we pass in
        /// <br> Note: switch method inside that parses the enum as an int</br>
        /// </summary>
        /// <param name="animalType">What kind of Animal is it? (Unassigned, Mammal, Reptile, Plant)"</param>
        /// <param name="species">The animals species value when creating the object</param>
        /// <returns>String that describe what kind of animal it is
        /// If the user defined a species when creating the object the user value is returned</returns>
        protected string GetAnimalType(AnimalType animalType, string species)
        {
            if (species == "[]")
            {
                return (int)animalType switch
                {
                    0 => "Mammal",
                    1 => "Reptile",
                    2 => "Plant",
                    -1 => "Unassigned Spieces",
                    _ => "Unkown Spieces, how did we get here?"
                };
            }
            else
            {
                return species;
            }
        }
    }
}
