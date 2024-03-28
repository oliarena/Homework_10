namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>(5);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            int[] array = list.GetArray();
            
            Console.WriteLine("Array : " + String.Join(',', array));

            Console.ReadKey();
        }
    }
}