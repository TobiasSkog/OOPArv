using OOPArv.AnimalTypes;

namespace OOPArv.Animals
{
    public class Human : Mammal
    {
        protected bool _socialFobi { get; set; }
        //public Human(bool socialFobi = true) : base(name: "Människan", diet: "burgerking", age: 22, isWild: true, furType: "lång och ovårdad")
        //{
        //    _socialFobi = socialFobi;
        //}
        public Human(
            string name = "Människan",
            string species = "[]",
            string diet = "donken",
            int age = 33,
            bool isWild = false,
            AnimalType animalType = AnimalType.Mammal,
            string furType = "flintskallig",
            bool socialFobi = false
        ) : base(name, species, diet, age, isWild, animalType, furType)
        {
            _socialFobi = socialFobi;
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
