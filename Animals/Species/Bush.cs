using OOPArv.AnimalTypes;

namespace OOPArv.Animals.Species
{
    internal class Bush : Plant
    {
        protected bool _invasive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">string - name of the bush</param>
        /// <param name="species">string - species of the bush</param>
        /// <param name="diet">string - the diet of the bush, lowercase</param>
        /// <param name="age">int - the current age of the bush</param>
        /// <param name="isWild">bool - if the bush is wild</param>
        /// <param name="animalType">enum - type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="hasThorns">bool - if the bush have thorns</param>
        /// <param name="invasive"><bool - if the bush is invasive/param>
        public Bush(
            string name = "Busken",
            string species = "[]",
            string diet = "maskiner",
            int age = 54,
            bool isWild = true,
            AnimalType animalType = AnimalType.Plant,
            bool hasThorns = false,
            bool invasive = false
        ) : base(name, species, diet, age, isWild, animalType, hasThorns)
        {
            _invasive = invasive;
        }

        public void Grow()
        {
            if (_invasive)
            {
                Console.WriteLine($"{_name} växer och tar över hela trädgården.");
            }
            else
            {
                Console.WriteLine($"{_name} växer ett nytt blad.");
            }
        }
    }
}