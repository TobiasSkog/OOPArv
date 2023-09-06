using OOPArv.AnimalTypes;

namespace OOPArv.Animals
{
    public class Dog : Mammal
    {
        protected bool _likesToSleep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">string - name of the dog</param>
        /// <param name="species">string - species of the dog</param>
        /// <param name="diet">string - the diet of the dog, lowercase</param>
        /// <param name="age">int - the current age of the dog</param>
        /// <param name="isWild">bool - if the dog is wild</param>
        /// <param name="animalType">enum - type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="furType">string - description of the fur of the dog</param>
        /// <param name="likesToSleep">bool - if the dog likes to sleep</param>
        public Dog(
            string name = "Hunden",
            string species = "[]",
            string diet = "torrfoder",
            int age = 5,
            bool isWild = false,
            AnimalType animalType = AnimalType.Mammal,
            string furType = "lång och mjukt",
            bool likesToSleep = true
        ) : base(name, species, diet, age, isWild, animalType, furType)
        {
            _likesToSleep = likesToSleep;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Woff");
        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} äter allt.");
        }
        public override void AdaptToEnviroment()
        {
            Console.WriteLine($"{_name} förlitar sig på människan för sin överlevnad.");
        }
    }
}
