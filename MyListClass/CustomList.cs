﻿using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public T this[int i]
        {
            get
            {
                if (i <= _count && i >= 0) 
                {
                    return _items[i];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set 
            {
                if(i <= _count && i >= 0)
                {
                    _items[i] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

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
            int index = 0;
            T[] temporary = _items;
     
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
                index++;
            }
           
            if (haveValue)
            {
                for (int i = index; index < _capacity - 1; i++)
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
                }
                _count--;
            }
        }
        public override string ToString()
        {
            string concat = "";
            for (int i = 0; i < _count; i++)
            {
                concat += _items[i].ToString();
            }
            return concat;
        }
        public static CustomList<T> operator +(CustomList<T> customList, CustomList<T> customList1)
        {
            CustomList<T> customListConcat = new CustomList<T>();

            for(int i = 0; i < customList.Count; i++)
            {
                customListConcat.Add(customList[i]);
            }
            for (int i = 0; i < customList1.Count; i++)
            {
                customListConcat.Add(customList[i]);
            }

            return customListConcat;
        }
    }
}
