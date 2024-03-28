namespace Task_3
{
    internal class Program
    {
        delegate string GiftGenerator<T>();

        static void Main(string[] args)
        {
            MagicBag<IAnimal> magicBag = new MagicBag<IAnimal>();
            IMagicBag<IAnimal>.AddGift("cat", "toy fish");
            IMagicBag<IAnimal>.AddGift("dog", "rubber duck");

            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Dog dog = new Dog();
            Hamster hamster = new Hamster();

            magicBag.GetGift(cat1);
            magicBag.GetGift(cat2);
            magicBag.GetGift(dog);
            magicBag.GetGift(hamster);

            IMagicBag<IAnimal>.AddGift("hamster", "running wheel");
            magicBag.GetGift(hamster);
            magicBag.GetGift(cat1);

            Console.WriteLine(new string('-', 25));
            Console.WriteLine(magicBag.ToString());

            Console.ReadKey();
        }
    }
}