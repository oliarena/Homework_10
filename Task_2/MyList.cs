using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Task_2
{
    internal class MyList<T> : IMyList<T>
    {
        private T[] _list;

        private int _size;

        public T this[int index] => _list[index];

        public int Count => _size;

        public MyList()
        {
            _list = new T[0];
        }

        public MyList(int length)
        {
            _list = new T[length];
        }

        public void Add(T value)
        {
            if (_size == _list.Length)
            {
                T[] list = new T[_list.Length + 1];
                _list.CopyTo(list, 0);
                _list = list;
            }
  
            _list[_size] = value;
            _size++;
        }

        public void Clear()
        {  
            if (_size == 0)
            {
                return;
            }

            Array.Clear(_list);
            _size = 0;
        }

        public bool Contains(T value)
        { 
            return IndexOf(value) >= 0;
        }

        public int IndexOf(T value)
        {
            return Array.IndexOf(_list, value);
        }

        public void Insert(int index, T value)
        {
            if (index > _size)
            {
                Console.WriteLine("Error. Index is out of range. It should be less than {0}", _size + 1);
            }

            if (_size == _list.Length)
            {
                T[] list = new T[_size + 1];
                _list.CopyTo(list, 0);
                _list = list;
            }

            if (index < _size)
            {
                Array.Copy(_list, index, _list, index + 1, _size - index);
            }
            _list[index] = value;
            _size++;
        }

        public void Remove(T value)
        {
            int index = IndexOf(value);
            if (index >= 0)
            {
                RemoveAt(index);
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= _size)
            {
                Console.WriteLine("Error. Index is out of range.");
            }

            _size--;
            if (index < _size)
            {
                Array.Copy(_list, index + 1, _list, index, _size - index);
            }
        }

        public override string ToString()
        {
            T[] list = new T[_size];
            Array.Copy(_list, list, _size);
            return String.Join(", ", list);
        }
    }


}
