using System;
using System.CodeDom;
using System.CodeDom.Compiler;
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


        // check to see if 'i' is "valid"
        // if not, throw an exception
        // throw new ArgumentOutOfRangeException();
        public T this[int i]
        {
            get
            {
                if (i <= _capacity) // switch to count, also, make sure cannot access negative
                {
                    return _items[i];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set // don't forget about me!
            {
                _items[i] = value;
            }
        }

        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }

        public void Add(T item)
        {
            if (_count == _capacity)
            {
                _capacity = _capacity * 2;
                T[] temporary = _items;
                _items = new T[_capacity];
                for (int i = 0; i < Count; i++)
                {
                    _items[i] = temporary[i];
                }

            }

            _items[_count] = item;
            _count++;
        }

        public void Remove(T item)
        {
            bool haveValue = false;
            int notOutOfBounds = 0;
            T[] temporary = _items;
            //do
            //{
                for (int i = 0; i < _items.Length; i++)
                {
                    if (item.Equals(_items[i]))
                    {
                        haveValue = true;
                        break;
                    }
                    else
                    {
                        _items[i] = temporary[i];
                    }
                    notOutOfBounds++;
                }
            // } while (haveValue == false && notOutOfBounds <= _count);
            if (haveValue)
            {
                for (int i = notOutOfBounds; notOutOfBounds < _capacity - 1; i++)
                {
                    if (i == _capacity - 1)
                    {
                        _items[i] = default(T);
                        break;
                    }
                    else
                    {
                        _items[i] = temporary[i + 1];
                    }
                    continue;
                }
                _count--;
            }
        }
    }
}
