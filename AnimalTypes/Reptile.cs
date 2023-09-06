using OOPArv.Animals;

namespace OOPArv.AnimalTypes
{
    public class Reptile : Animal
    {
        protected bool _hasScales;
        public Reptile(string name, string species, string diet, int age, bool isWild, AnimalType animalType, bool hasScales) : base(name, species, diet, age, isWild, animalType)
        {
            _hasScales = hasScales;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Hzzzzzzzzzzzzz");
        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} äter {_diet} för näring.");
        }
        public override void AdaptToEnviroment()
        {
            Console.WriteLine(_hasScales ? $"{_name} har anpassat sig med fjäll för att skydda sig mot andra djur." :
                                           $"{_name} har anpassat sig med giftiga klor eller tänder för att försvara sig mot andra djur.");
        }
    }
}
