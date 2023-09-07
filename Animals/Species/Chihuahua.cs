namespace OOPArv.Animals.DogRaces
{
    internal class Chihuahua : Dog
    {
        protected bool _isSpoiled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">string - name of the chihuahua</param>
        /// <param name="species">string - species of the chihuahua</param>
        /// <param name="diet">string - the diet of the chihuahua, lowercase</param>
        /// <param name="age">int - the current age of the chihuahua</param>
        /// <param name="isWild">bool - if the chihuahua is wild</param>
        /// <param name="animalType">enum - type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="furType">string - description of the fur of the chihuahua</param>
        /// <param name="likesToSleep">bool - if the chihuahua likes to sleep</param>
        /// <param name="isSpoiled">bool - if the chihuahua is spoiled</param>
        public Chihuahua(
            string name = "Chihuahuan",
            string species = "[]",
            string diet = "wiener-bröd",
            int age = 2,
            bool isWild = true,
            AnimalType animalType = AnimalType.Mammal,
            string furType = "kort och äcklig",
            bool likesToSleep = true,
            bool isSpoiled = true
        ) : base(name, species, diet, age, isWild, animalType, furType, likesToSleep)
        {
            _isSpoiled = isSpoiled;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Iiiiiiiih.");
        }
        public override void WiggleTail()
        {
            Console.WriteLine($"{_name} viftar vådlsamt på svansen.");
        }

        public void BegForFood()
        {
            Console.WriteLine($"{_name} vill ha maten du äter.");
        }
    }
}
