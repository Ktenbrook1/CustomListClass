using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListClass
{
    public class CustomList<T>
    {

        T[] _items;

        int _capacity;
        int _count;

        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }
        //original constructor was put here

        public void Add(T item)
        {

            if (_count == _capacity)
            {
                _capacity = _capacity * 2;
                T[] temporary = _items;
                _items = new T[_capacity];
                for(int i = 0; i < Count; i++)
                {
                    _items[i] = temporary[i];
                }
            }
            _items[_count] = item;
            _count++;
        }
        public T this[int i]
        {
            get { return _items[i]; }
            set { _items[i] = value; }
        }

    }
}
