using OOPArv.AnimalTypes;

namespace OOPArv.Animals
{
    public class Cat : Mammal
    {
        protected bool _isFriendly { get; set; }
        public Cat(
            string name = "Katten",
            string species = "[]",
            string diet = "inte det som serveras",
            int age = 16,
            bool isWild = false,
            AnimalType animalType = AnimalType.Mammal,
            string furType = "lång och mjuk",
            bool isFriendly = true
        ) : base(name, species, diet, age, isWild, animalType, furType)
        {
            _isFriendly = isFriendly;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Mjaooo.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} behöver {_diet} för näring, men föredrar cheez cruncherz och vad det än är som tillreds på spisen.");
        }
        public override void AdaptToEnviroment()
        {
            Console.WriteLine($"{_name} tillåter människan vara i dens närhet för att få tillgång till bättre föda.");
        }
    }
}
