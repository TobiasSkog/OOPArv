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
    /// Abstract Super Class Animal that will be the base for all the subclasses in this project
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
        /// Default values are assigned if an attribute is leftout
        /// Using the GetAnimalType method to assign a default value to _speices
        /// </summary>
        /// <param name="name">string - name of the animal</param>
        /// <param name="diet">string - the diet of the animal</param>
        /// <param name="age">int - the current age of the animal</param>
        /// <param name="isWild">bool - if the animal is wild</param>
        /// <param name="animalType">enum - type of animal (Mammal, Reptile, Plant)</param>
        public Animal(string name = "Kattla", string species = "[]", string diet = "Mums-Mums", int age = 42, bool isWild = true, AnimalType animalType = AnimalType.Unassigned)
        {
            _name = name;
            _diet = diet;
            _species = GetAnimalType(animalType, species);
            _age = age;
            _isWild = isWild;
            _animalType = animalType;
        }

        public AnimalType ANIMALTYPE
        {
            get { return _animalType; }
        }
        /// <summary>
        /// Writes out to the console the name, species and age of the Animal
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
        /// will write out how the animal adapted to its envirement
        /// </summary>
        public abstract void AdaptToEnviroment();


        protected string GetAnimalType(AnimalType animalType, string species)
        {

            Console.WriteLine(animalType.ToString());

            if (species == "[]" && animalType != AnimalType.Unassigned)
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
            else if (species == "[]")
            {
                return "Unassigned Spieces";
            }
            else
            {
                return species;
            }



            //switch (animalType)
            //{
            //    case AnimalType.Mammal:
            //        return "Mammal";
            //    case AnimalType.Reptile:
            //        return "Reptile";
            //    case AnimalType.Plant:
            //        return "Plant";
            //    default:
            //        return "Unkown Spieces";
            //}

            //
            //Unassigned = -1,
            //Mammal = 0,
            //Reptile = 1,
            //Plant = 2



        }
    }
}
