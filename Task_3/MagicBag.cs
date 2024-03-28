namespace Task_3
{
    internal class MagicBag<T>:IMagicBag<T> where T : IAnimal
    {
        private readonly Dictionary<T, DateTime> _givenGifts;

        public MagicBag()
        {
            _givenGifts = new Dictionary<T, DateTime>();
        }

        public void GetGift(T animal)
        {
            if (!IMagicBag<T>.Gifts.ContainsKey(animal.AnimalType))
            {
                Console.WriteLine($"Sorry the magic bag doesn't have a present for {animal.AnimalType}");
                return;
            }

            string gift = IMagicBag<T>.Gifts[animal.AnimalType];

            if (_givenGifts.ContainsKey(animal) && _givenGifts[animal].Date == DateTime.Today)
            {
                Console.WriteLine($"Sorry {animal.AnimalType} already got the present today. Welcome back tomorrow.");
            }
            else
            {
                _givenGifts[animal] = DateTime.Today;
                Console.WriteLine($"{animal.AnimalType} got the {gift}");
            }
        }

        public override string ToString() {
            string result = "Presents in bag: \n";
            foreach (var gift in IMagicBag<T>.Gifts)
            {
                result += gift.Value + " for " + gift.Key + "\n";
            }
            result += "Animals with presents:\n";
            foreach (var gift in _givenGifts)
            {
                result += gift.Key?.AnimalType + " on " + gift.Value.Date.ToShortDateString() + "\n";
            }
            return result;     
        }
    }
}
