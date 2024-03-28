namespace Task_3
{
    internal class Animal
    {     
    }

    internal class Cat: IAnimal
    {
        public string AnimalType { get; } = "cat";
    } 

    internal class Dog : IAnimal
    {
        public string AnimalType { get; } = "dog";
    }

    internal class Hamster : IAnimal
    {
        public string AnimalType { get; } = "hamster";
    }
}
