namespace Task_3
{
    internal interface IMagicBag<T> where T : IAnimal
    {
        static Dictionary<string, string> Gifts { get; } = new Dictionary<string, string>();

        static void AddGift(string animalType, string gift)
        {
            Gifts[animalType] = gift;
        }

        void GetGift(T animal);
    }
}
