using OOPArv.Animals;
using OOPArv.Animals.DogRaces;
using OOPArv.Animals.Species;
using OOPArv.AnimalTypes;

internal class Program
{
    static void Main(string[] args)
    {

        // List of animals to make method calling easier and less repetetive later in the code
        List<Animal> animals = new List<Animal>();


        // Creating a new object of Dog, Cat, Chihuahua, Bulldog, Turtle, Human, Bush, Mammal, Reptile
        // Testing the default constructor with default values for all the attributes in each class
        Dog dog = new();
        Cat cat = new();
        Chihuahua dog_chihuahua = new();
        Bulldog dog_bulldog = new();
        Turtle turtle = new();
        Human human = new();
        Bush bush = new();
        Mammal mammal = new();
        Reptile reptile = new();



        // Creating a new object of Dog, Cat, Chihuahua, Bulldog, Turtle, Human, Bush, Mammal, Reptile
        // Testing the overload constructor with values for all the attributes in each class
        Dog dog2 = new("Båtsman", "en Golden-Retriever", "torrfoder", 16, false, AnimalType.Mammal, "tjock och yvig");
        Cat cat2 = new("Larre", "en Bondkatt", "Torrfoder", 11, false, AnimalType.Mammal, "kort och sträv", true);
        Chihuahua dog_chihuahua2 = new("Carl-Erik Von Blundervik", "en Chihuahua", "bullar", 4, false, AnimalType.Mammal, "kort och stickig");
        Bulldog dog_bulldog2 = new("Francis", "en Bulldog", "blötmat", 9, false, AnimalType.Mammal, "kort och sträv");
        Turtle turtle2 = new("Åke", "en Aldabrasköldpadda", "gräsätare", 126, true, AnimalType.Reptile, true, "Cryptodira");
        Human human2 = new("Sebastian", "en Människa", "allätare", 35, true, AnimalType.Mammal, "flintskallig");
        Bush bush2 = new("Buske", "en variant av Buskes-buskus", "vitpeppar", 15, true, AnimalType.Plant, true, true);
        Mammal mammal2 = new("Däggdjure", "ett däggdjur", "allt möjligt", 95, false, AnimalType.Mammal, "fluffigt och tovigt");
        Reptile reptile2 = new("Reptilen", "en reptil", "potatismos", 21, false, AnimalType.Reptile, false);

        // Adding all the newly created objects into the list of animals
        animals.Add(dog);
        animals.Add(cat);
        animals.Add(dog_chihuahua);
        animals.Add(dog_bulldog);
        animals.Add(human);
        animals.Add(turtle);
        animals.Add(bush);
        animals.Add(mammal);
        animals.Add(reptile);
        animals.Add(dog2);
        animals.Add(cat2);
        animals.Add(dog_chihuahua2);
        animals.Add(dog_bulldog2);
        animals.Add(human2);
        animals.Add(turtle2);
        animals.Add(bush2);
        animals.Add(mammal2);
        animals.Add(reptile2);

        // For every animal we call the methods 
        // Introduction, MakeSound, Eat, AdaptToEnvironment
        // Then we apply logic to check if the current animal is 
        // of a specific subclass then we call that specific class 
        // extra method then add a new line at the end to make 
        // the output easier to read
        foreach (var animal in animals)
        {
            animal.Introduction();
            animal.MakeSound();
            animal.Eat();
            animal.AdaptToEnvironment();

            if (animal is Dog d)
            {
                d.WiggleTail();

                if (animal is Chihuahua dog_c)
                {
                    dog_c.BegForFood();
                }
                else if (animal is Bulldog dog_b)
                {
                    dog_b.Drool();
                }
            }
            else if (animal is Cat c)
            {
                c.Climb();
            }
            else if (animal is Turtle t)
            {
                t.RunAway();
            }
            else if (animal is Human h)
            {
                h.Study();
            }
            else if (animal is Bush b)
            {
                b.Grow();
            }
        }
    }
}