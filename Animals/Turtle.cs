using OOPArv.AnimalTypes;

namespace OOPArv.Animals
{
    public class Turtle : Reptile
    {
        // cold-blooded omnivores 178 years lifespan neck = Cryptodira / Pleurodira
        protected string _neckRetraction { get; set; }
        //public Turtle()
        //{
        //    base._name = "Turtle";
        //    base._diet = "Leaves";
        //    base._species = "Big Turtle";
        //    base._age = 10;
        //    base._isWild = true;
        //    base._animalType = AnimalType.Reptile;
        //    base._hasScales = true;
        //    _neckRetraction = "Cryptodira";
        //}
        public Turtle()
        {
            _name = "Mona";
            _diet = "Leaves";
            _species = "en stor sköldpadda";
            _animalType = AnimalType.Reptile;
            _neckRetraction = "Cryptodira";
        }
        //public Turtle(string name, string species, string diet, int age, bool isWild, bool hasScales, string neckRetraction) : base(name, species, diet, age, isWild, AnimalType.Reptile, hasScales)
        //{
        //    _neckRetraction = neckRetraction;
        //}
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
