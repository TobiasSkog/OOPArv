using OOPArv.AnimalTypes;

namespace OOPArv.Animals
{
    public class Dog : Mammal
    {
        protected bool _likesToSleep { get; set; }
        public Dog(
            string name = "Hunden",
            string species = "[]",
            string diet = "torrfoder",
            int age = 5,
            bool isWild = false,
            AnimalType animalType = AnimalType.Mammal,
            string furType = "lång och mjukt",
            bool likesToSleep = true
        ) : base(name, species, diet, age, isWild, animalType, furType)
        {
            _likesToSleep = likesToSleep;
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
