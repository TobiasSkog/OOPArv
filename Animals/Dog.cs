using OOPArv.AnimalTypes;

namespace OOPArv.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, string species, string diet, int age, bool isWild, string furType) : base(name, species, diet, age, isWild, AnimalType.Mammal, furType)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Woff");
        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} äter allt.");
        }
        public override void AdaptToEnviroment()
        {
            Console.WriteLine($"{_name} förlitar sig på människan för sin överlevnad.");
        }
    }
}
