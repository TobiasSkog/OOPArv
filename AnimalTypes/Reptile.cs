using OOPArv.Animals;

namespace OOPArv.AnimalTypes
{
    /// <summary>
    /// Reptile class that inherits from the Super Class Animal
    /// </summary>
    public class Reptile : Animal
    {
        /// <summary>
        /// A singular attribute that's unique to the Reptile Class
        /// </summary>
        protected bool _hasScales;

        /// <summary>
        /// Constructor for the Reptile class wich assigns default values
        /// to all the attributes unless a value is specified in the creation
        /// </summary>
        /// <param name="name">string - name of the reptile</param>
        /// <param name="species">string - species of the reptile</param>
        /// <param name="diet">string - the diet of the reptile, lowercase</param>
        /// <param name="age">int - the current age of the reptile</param>
        /// <param name="isWild">bool - if the reptile is wild</param>
        /// <param name="animalType">enum - type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="hasScales">bool - if the reptile have scales or not</param>
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
        public override void MakeSound()
        {
            Console.WriteLine($"Hzzzzzzzzzzzzz");
        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} äter {_diet} för näring.");
        }
        public override void AdaptToEnviroment()
        {
            Console.WriteLine(_hasScales ? $"{_name} har anpassat sig med fjäll för att skydda sig mot andra djur." :
                                           $"{_name} har anpassat sig med giftiga klor eller tänder för att försvara sig mot andra djur.");
        }
    }
}
