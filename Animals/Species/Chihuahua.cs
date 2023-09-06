namespace OOPArv.Animals.DogRaces
{
    internal class Chihuahua : Dog
    {
        protected bool _isSpoiled { get; set; }
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
    }
}
