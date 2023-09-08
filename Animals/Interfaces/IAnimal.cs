namespace OOPArv.Animals.Interfaces
{
    /// <summary>
    /// Implementing the interface of all the methods that will be required by all
    /// classes and subclasses in this assignment 
    /// </summary>
    public interface IAnimal
    {
        public void Introduction();
        public void MakeSound();
        public void Eat();
        public void AdaptToEnvironment();
    }
}