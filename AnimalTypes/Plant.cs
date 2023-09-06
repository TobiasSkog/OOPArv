using OOPArv.Animals;

namespace OOPArv.AnimalTypes
{
    public class Plant : Animal
    {
        protected bool _hasThorns { get; set; }

        public Plant(
            string name = "Plantan",
            string species = "[]",
            string diet = "jord",
            int age = 5,
            bool isWild = true,
            AnimalType animalType = AnimalType.Plant,
            bool hasThorns = true
        ) : base(name, species, diet, age, isWild, animalType)
        {
            _hasThorns = hasThorns;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{_name} ger ifrån sig ett vistlande ljud då vinden kraftigt skakar alla bladen.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} får sin näring från jorden och energin från soljus genom fotosyntes.");
        }
        public override void AdaptToEnviroment()
        {
            Console.WriteLine(_hasThorns ? $"{_name} har anpassat sig med taggar för att skydda sig mot faror." :
                                           $"{_name} har anpassat sig med giftiga blad för att skydda sig mot faror.");
        }


    }
}
