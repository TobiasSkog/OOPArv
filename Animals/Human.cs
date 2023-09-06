using OOPArv.AnimalTypes;

namespace OOPArv.Animals
{
    public class Human : Mammal
    {
        public Human(string name, string species, string diet, int age, bool isWild, string furType) : base(name, species, diet, age, isWild, AnimalType.Mammal, furType)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine($"Va? Nä inte nu, jag har inte tid.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} behöver ät {_diet} för näring, men idag blev det en biltema korv.");
        }
        public override void AdaptToEnviroment()
        {
            Console.WriteLine($"{_name} anpassade miljön runt omkring sig istället för att anpassa sig själv för överlevnad.");
        }
    }
}
