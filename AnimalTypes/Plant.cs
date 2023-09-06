using OOPArv.Animals;

namespace OOPArv.AnimalTypes
{
    public class Plant : Animal
    {
        protected bool _hasThorns { get; set; }

        public Plant()
        {
            _name = "Plantan";
            _diet = "Soil";
            _animalType = AnimalType.Plant;
            _hasThorns = true;
        }
        public Plant(string name, string species, string diet, int age, bool isWild, AnimalType animalType, bool hasThorns) : base(name, species, diet, age, isWild, animalType)
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
