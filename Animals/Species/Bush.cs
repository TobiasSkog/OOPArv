using OOPArv.AnimalTypes;

namespace OOPArv.Animals.Species
{
    internal class Bush : Plant
    {
        public Bush(string name, string species, string diet, int age, bool isWild, bool hasThorns) : base(name, species, diet, age, isWild, AnimalType.Mammal, hasThorns)
        {

        }
    }
}
