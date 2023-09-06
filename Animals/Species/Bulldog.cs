namespace OOPArv.Animals.DogRaces
{
    internal class Bulldog : Dog
    {
        protected bool _isDrooling { get; set; }
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
    }
}
