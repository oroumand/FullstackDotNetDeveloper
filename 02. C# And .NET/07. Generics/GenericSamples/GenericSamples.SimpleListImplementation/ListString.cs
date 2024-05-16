namespace GenericSamples.SimpleListImplementation
{
    public class ListString
    {

        public string this[int i] { get { return GetItemAt(i); } set { ReplaceAt(i, value); } }


        private int _capacity = 4;
        private int _count = 0;
        private string[] _items = new string[4];
        public int Count => _count;
        public int Capacity => _capacity;

        public void Add(string item)
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
                string[] tempItems = new string[_capacity];
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
            _items[_count] = string.Empty;
        }

        public string GetItemAt(int index)
        {
            if (index > _count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            return _items[index];
        }

        public void ReplaceAt(int index, string item)
        {
            if (index > _count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            _items[index] = item;
        }
    }
}
