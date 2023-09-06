using OOPArv.AnimalTypes;

namespace OOPArv.Animals
{
    public class Turtle : Reptile
    {
        protected string _neckRetraction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">string - name of the turtle</param>
        /// <param name="species">string - species of the turtle</param>
        /// <param name="diet">string - the diet of the turtle, lowercase</param>
        /// <param name="age">int - the current age of the turtle</param>
        /// <param name="isWild">bool - if the turtle is wild</param>
        /// <param name="animalType">enum - type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="hasScales">bool - if the turtle have scales or not</param>
        /// <param name="neckRetraction">string - the kind of neck retraction the turtle have</param>
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
