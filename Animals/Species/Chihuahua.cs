namespace OOPArv.Animals.DogRaces
{
    internal class Chihuahua : Dog
    {
        // Unique attribute of the Chihuahua class and all it's sub classes
        // Protected and encapsulated in the scope of the class (and subclasses)
        protected bool _isSpoiled { get; set; }

        /// <summary>
        /// Constructor for the Chihuahua class that assigns new values as defaults if a Chihuahua is created
        /// </summary>
        /// <param name="name">The name of the chihuahua</param>
        /// <param name="species">The species of the chihuahua</param>
        /// <param name="diet">The diet of the chihuahua, lowercase</param>
        /// <param name="age">The the current age of the chihuahua</param>
        /// <param name="isWild">If the chihuahua is wild</param>
        /// <param name="animalType">The type of animal (Unassigned, Mammal, Reptile, Plant)</param>
        /// <param name="furType">Short description of the fur of the chihuahua</param>
        /// <param name="likesToSleep">If the chihuahua likes to sleep</param>
        /// <param name="isSpoiled">If the chihuahua is spoiled</param>
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
        /// <summary>
        /// Writes out the sound a Chihuahua makes to the console
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Iiiiiiiih.");
        }
        /// <summary>
        /// Writes out the eating habbits of a Chihuahua to the console
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine($"{_name} äter bara farmors bullar och rosé.");
        }
        /// <summary>
        /// Writes out the way a Chihuahua adapted to its enviroment for survival to the console
        /// </summary>
        public override void AdaptToEnviroment()
        {
            Console.WriteLine($"{_name} förlitar sig på människan för sin överlevnad, föredrar märkeskläder på vintern för att hålla värmen.");
        }
        /// <summary>
        /// Writes out that Chihuahua is wiggling it's tail
        /// </summary>
        public override void WiggleTail()
        {
            Console.WriteLine($"{_name} viftar vådlsamt på svansen.");
        }

        /// <summary>
        /// Writes out that the Chihuahua begs for food
        /// </summary>
        public void BegForFood()
        {
            Console.WriteLine($"{_name} vill ha maten du äter.");
        }
    }
}
