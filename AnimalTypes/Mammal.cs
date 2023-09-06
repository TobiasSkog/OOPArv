using OOPArv.Animals;

namespace OOPArv.AnimalTypes
{

    public class Mammal : Animal
    {
        protected string _furType;
        public Mammal(string name, string species, string diet, int age, bool isWild, AnimalType animalType, string furType) : base(name, species, diet, age, isWild, animalType)
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
            Console.WriteLine($"{_name} anpassar sig till miljönd med {_furType} päls för värme och skydd.");
        }
    }
}


