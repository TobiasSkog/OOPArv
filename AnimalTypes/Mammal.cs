using OOPArv.Animals;

namespace OOPArv.AnimalTypes
{

    public class Mammal : Animal
    {
        protected string _furType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">string - name of the mammal</param>
        /// <param name="species">string - species of the mammal</param>
        /// <param name="diet">string - the diet of the mammal, lowercase</param>
        /// <param name="age">int - the current age of the mammal</param>
        /// <param name="isWild">bool - if the mammal is wild</param>
        /// <param name="animalType">enum - type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="furType">string - description of the fur of the mammal</param>
        public Mammal(
            string name = "Däggdjuret",
            string species = "[]",
            string diet = "fiskbullar",
            int age = 22,
            bool isWild = true,
            AnimalType animalType = AnimalType.Mammal,
            string furType = "kort och mjukt"
        ) : base(name, species, diet, age, isWild, animalType)
        {
            _furType = furType;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{_name} Bröööööööööl.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} äter {_diet} för näring.");
        }
        public override void AdaptToEnviroment()
        {
            Console.WriteLine($"{_name} anpassar sig till miljön med {_furType} päls för värme och skydd.");
        }
    }
}


