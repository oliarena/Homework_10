namespace Task_2
{
    internal interface IMyList<T> 
    {
        T this[int index] { get; }

        int Count { get; }

        void Add(T value);

        void Clear();

        bool Contains(T value);

        int IndexOf(T value);

        void Insert(int index, T value);

        void Remove(T value);

        void RemoveAt(int index);

    }
}
