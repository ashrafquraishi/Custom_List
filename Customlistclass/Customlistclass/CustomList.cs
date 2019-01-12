using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_list_class
{
    public class CustomList<T>
    {
        T[] data;
        int count;

        int capacity;
        public T[] myListArray;
        private T[] items;

        public CustomList()
        {
            count = 0;
            capacity = 5;
            myListArray = new T[capacity];
        }
        public CustomList(int capacity)
        {
            count = 0;
            myListArray = new T[capacity];
            this.capacity = capacity;
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int MyListCount()
        {
            return this.count;
        }
        public int MyListCapacity()
        {
            return this.capacity;
        }

        public void Add(T value)
        {
            T[] temp = new T[capacity * 2];

            for (int i = 0; i < Count; i++)
            {
                temp[i] = temp[i];
            }
            if (Count == capacity)
            {
                capacity = capacity * 2;
            }
            temp[count] = value;
            count++;
            items = temp;
            SetCount();
        }
        private void SetCount()
        {
            int i = 0;
            foreach (T value in this)
            {
                i++;
            }
            count = i;
        }

        public void DoubleArraySize()
        {
            int doubleCapacity = capacity * 2;
            T[] temporary = new T[(doubleCapacity)];
            for (int i = 0; i < (capacity); i++)
            {
                temporary[i] = myListArray[i];
            }
            capacity = capacity * 2;
            myListArray = temporary;
        }


        public bool Remove(T item)
        {
            T[] temporary = new T[capacity];
            bool shiftDown = false;
            for (int i = 0; i < count; i++)
            {
                if (myListArray[i].Equals(item))
                {
                    temporary[i] = myListArray[i + 1];
                    count--;
                    // shiftDown = true;///
                }
                else if (shiftDown == true)
                {
                    temporary[i] = myListArray[i + 1];
                }
                else
                {
                    temporary[i] = myListArray[i];
                }
            }
            myListArray = temporary;
            return shiftDown;
        }
        

        public override string ToString()
        {
            string myString = "";
            foreach (T element in myListArray)
            {
                myString += string.Format("{0}", element);
            }
            return myString;
        }
        public T this[int i]
        {
            get
            {
                if (i >= count)
                {
                    return default(T);
                }
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }
    }


}
        
    

    


