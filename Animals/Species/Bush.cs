using OOPArv.AnimalTypes;

namespace OOPArv.Animals.Species
{
    internal class Bush : Plant
    {
        protected bool _invasive { get; set; }
        public Bush(
            string name = "Plantan",
            string species = "[]",
            string diet = "jord",
            int age = 5,
            bool isWild = true,
            AnimalType animalType = AnimalType.Plant,
            bool hasThorns = true,
            bool invasive = true
        ) : base(name, species, diet, age, isWild, animalType, hasThorns)
        {
            _invasive = invasive;
        }
    }
}
