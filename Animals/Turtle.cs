using OOPArv.AnimalTypes;

namespace OOPArv.Animals
{
    public class Turtle : Reptile
    {
        protected string _neckRetraction { get; set; }
        public Turtle(
            string name = "Sköldpaddan",
            string species = "[]",
            string diet = "kottar",
            int age = 85,
            bool isWild = true,
            AnimalType animalType = AnimalType.Reptile,
            bool hasScales = true,
            string neckRetraction = "Cryptodira"
        ) : base(name, species, diet, age, isWild, animalType, hasScales)
        {
            _neckRetraction = neckRetraction;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"hhhssssss");
        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} äter {_diet} för näring.");
        }
        public override void AdaptToEnviroment()
        {
            Console.WriteLine($"{_name} har ett starkt skal för att skydda sig mot faror.");
        }
    }
}
