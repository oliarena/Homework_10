namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>(5);
            list.Add(1);
            Console.WriteLine("Add 1 : "+ list.ToString());
            list.Add(2);
            Console.WriteLine("Add 2 : " + list.ToString());
            list.Add(3);
            Console.WriteLine("Add 3 : " + list.ToString());
            list.Insert(1, 4);
            Console.WriteLine("Insert 4 at 1 : " + list.ToString());
            list.Remove(3);
            Console.WriteLine("Remove 3 : " + list.ToString());
            list.RemoveAt(1);
            Console.WriteLine("Remove at 1 : " + list.ToString());

            Console.WriteLine(list.Contains(1) ? "List constains 1" : "List doesn't constain 1");
           
            Console.ReadKey();
        }
    }
}