using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSamples.SimpleListImplementation
{
    public class ListGeneric<T>
    {

        public T this[int i] { get { return GetItemAt(i); } set { ReplaceAt(i, value); } }


        private int _capacity = 4;
        private int _count = 0;
        private T[] _items = new T[4];
        public int Count => _count;
        public int Capacity => _capacity;

        public void Add(T item)
        {
            AddCapacityIfNeeded();
            _items[_count] = item;
            _count++;
        }
        private void AddCapacityIfNeeded()
        {
            if (_capacity == _count)
            {
                _capacity = _capacity * 2;
                T[] tempItems = new T[_capacity];
                for (int i = 0; i < _count; i++)
                {
                    tempItems[i] = _items[i];
                }
                _items = tempItems;

            }
        }

        public void RemoveAt(int index)
        {
            if (index > _count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            _count--;
            for (int i = index; i < _count; i++)
            {
                _items[i] = _items[i + 1];
            }
            _items[_count] = default;

        }

        public T GetItemAt(int index)
        {
            if (index > _count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            return _items[index];
        }

        public void ReplaceAt(int index, T item)
        {
            if (index > _count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            _items[index] = item;
        }
    }
}
