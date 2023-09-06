using OOPArv.Animals;
using OOPArv.Animals.DogRaces;
using OOPArv.Animals.Species;
using OOPArv.AnimalTypes;

internal class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        Dog dog = new("Båtsman", "en Golden-Retriever", "torrfoder", 16, false, AnimalType.Mammal, "tjock och yvig");
        Cat cat = new("Larre", "en Bondkatt", "Torrfoder", 11, false, AnimalType.Mammal, "kort och sträv", true);
        Chihuahua dog_chihuahua = new("Carl-Erik Von Blundervik", "en Chihuahua", "bullar", 4, false, AnimalType.Mammal, "kort och stickig");
        Bulldog dog_bulldog = new("Francis", "en Bulldog", "blötmat", 9, false, AnimalType.Mammal, "kort och sträv");
        Turtle turtle = new("Åke", "en Aldabrasköldpadda", "gräsätare", 126, true, AnimalType.Reptile, true, "Cryptodira");
        Human human = new("Sebastian", "en Människa", "allätare", 35, true, AnimalType.Mammal, "flintskallig");
        Bush bush = new("Buske", "en variant av Buskes-buskus", "vitpeppar", 15, true, AnimalType.Plant, true, true);
        Mammal mammal = new();
        Reptile reptile = new();

        animals.Add(dog);
        animals.Add(cat);
        animals.Add(dog_chihuahua);
        animals.Add(dog_bulldog);
        animals.Add(human);
        animals.Add(turtle);
        animals.Add(bush);
        animals.Add(mammal);
        animals.Add(reptile);

        foreach (var animal in animals)
        {
            animal.Introduction();
            animal.MakeSound();
            animal.Eat();
            animal.AdaptToEnviroment();
            Console.WriteLine();
        }

    }
}