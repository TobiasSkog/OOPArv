using OOPArv.Animals;
using OOPArv.Animals.DogRaces;
using OOPArv.AnimalTypes;

internal class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        Dog dog = new Dog("Båtsman", "Golden", "Torrfoder", 16, false, "tjock och yvig");
        //Cat cat = new Cat("Larre", "Bondkatt", "Torrfoder", 11, false, "kort och sträv", true);
        Chihuahua dog_chihuahua = new Chihuahua("Carl-Erik Von Blundervik", "Chihuahua", "Bullar", 4, false, "kort och stickig");
        //Bulldog dog_bulldog = new Bulldog("Francis", "Bulldog", "Blötmat", 9, false, "kort och sträv");
        //Turtle turtle = new Turtle("Åke", "Aldabrasköldpadda", "Gräsätare", 126, true, true, "Cryptodira");
        //Human human = new Human("Sebastian", "Människa", "Allätare", 35, true, "flintskallig");
        //Bush bush = new Bush("Buske", "Buskesbuskus", "vitpeppar", 15, true, true);
        Mammal mammal = new();
        Reptile reptile = new();
        animals.Add(dog); animals.Add(dog_chihuahua); animals.Add(mammal); animals.Add(reptile);
        //animals.Add(dog); animals.Add(cat); animals.Add(dog_chihuahua); animals.Add(dog_bulldog); animals.Add(human); animals.Add(bush); animals.Add(test);
        //animals.Add(turtle);
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.ANIMALTYPE);

            animal.Introduction();
            animal.MakeSound();
            animal.Eat();
            animal.AdaptToEnviroment();
            Console.WriteLine();
        }

    }
}