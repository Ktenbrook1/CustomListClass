# CustomListClass
My version of the List class that imitates Microsoft 

This method Removes the first instance of the generic item passed in.

Syntax
public bool Remove(T item)

Parameters
(T item)
The object to be removed is generic from type CustomList<T>
  
Return type
bool
will return true if the value is found and false when it was not found.

Example

public void Remove_CountOf3()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(6);

            customList.Remove(customList[2]);
        }   
        
From the code above we are instantiating a new CustomList<T> object then we proceed  to add the values of 2, 3, 4, and 6 into the customList.
When the Remove method is hit we will then be taken to the method below.
  
   public bool Remove(T item)
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
                return true;
            }
            return false;
        }
        
   
When "customList.Remove(customList[2]);" is hit, it will take in the second index of this List, so the value "4".
The " T[] temporary = _items;" variable will serve as a placeholder for them _items array that we are woking with.
When we go into the for loop we are checking each item in the _items array. While searching for the value if it is
not found we are adding the value of i onto the _items array so that if the value is never found we will have the 
exact same array but the bool will return false because the value to be removed was never found. Once the value is
found (if ever) we will set the return type to true and break out of the loop.

It will then take us to the if statement "if (haveValue)". If haveValue is true we will go into the statement and
continue to loop through the array where we left off. We subtract one from the capacity so that the program does not
throw a ArgumentOutOfRangeException and also require the program to break at the end of the loop for the same reason.
The "_items[i] = default(T);" will set the last value to the default which was assigned 0. Up until the end of the 
loop is hit we will override the current index with the one after it. Once we are out of the for loop the count will
be decremented and return true. If we never go into this if statement then the value was never found, the count will
remain the same and we will return the bool of false.

The _items array will now be overridden with new values if the value to be removed was found.

        
        
        
        
        
        
        
        
        
        
