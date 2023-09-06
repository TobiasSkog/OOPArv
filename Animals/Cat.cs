using OOPArv.AnimalTypes;

namespace OOPArv.Animals
{
    public class Cat : Mammal
    {
        public Cat(string name, string species, string diet, int age, bool isWild, string furType) : base(name, species, diet, age, isWild, AnimalType.Mammal, furType)
        {

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
