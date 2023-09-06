namespace OOPArv.Animals.DogRaces
{
    internal class Chihuahua : Dog
    {
        public Chihuahua(string name, string species, string diet, int age, bool isWild, string furType) : base(name, species, diet, age, isWild, furType)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Iiiiiiiih.");
        }
    }
}
