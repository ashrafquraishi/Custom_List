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

        private T[] arr = new T[100];


        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public int Count
        {
         get
        {

          return count;

        }
        }
        public  int Capacity = 4;

       
        public CustomList()
        {
            
            data = new T[4];
            count = 0;
        }
    
        public void Add(T value)
        {

            T[] numbers = new T[Capacity * 2];
            data[count] = value;
            count++;
        }

    
    }
        
    

    

}
