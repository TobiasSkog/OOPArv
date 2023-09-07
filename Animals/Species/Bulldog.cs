namespace OOPArv.Animals.DogRaces
{
    internal class Bulldog : Dog
    {
        protected bool _isDrooling { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">string - name of the bulldog</param>
        /// <param name="species">string - species of the bulldog</param>
        /// <param name="diet">string - the diet of the bulldog, lowercase</param>
        /// <param name="age">int - the current age of the bulldog</param>
        /// <param name="isWild">bool - if the bulldog is wild</param>
        /// <param name="animalType">enum - type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="furType">string - description of the fur of the bulldog</param>
        /// <param name="likesToSleep">bool - if the bulldog likes to sleep</param>
        /// <param name="isDrooling">bool - if the bulldog is drooling</param>
        public Bulldog(
            string name = "Bulldogen",
            string species = "[]",
            string diet = "bullens pilsnerkorv",
            int age = 2,
            bool isWild = true,
            AnimalType animalType = AnimalType.Mammal,
            string furType = "kort och sträv",
            bool likesToSleep = true,
            bool isDrooling = true
        ) : base(name, species, diet, age, isWild, animalType, furType, likesToSleep)
        {
            _isDrooling = isDrooling;
        }
        public override void MakeSound()
        {
            Console.WriteLine("WÖFF");
        }

        public override void WiggleTail()
        {
            Console.WriteLine($"{_name} försöker vifta på svansen.");
        }

        public void Drool()
        {
            if (_isDrooling)
            {
                Console.WriteLine($"{_name} dregglar frenetiskt.");
            }
            else
            {
                Console.WriteLine($"{_name} har slutat dreggla.");
            }
        }
    }
}