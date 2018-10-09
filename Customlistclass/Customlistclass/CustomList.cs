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

        private T[] arr = new T[1];


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
        

       
        public CustomList()
        {
            
            data = new T[100];
            count = 0;
        }
       static public  int Capacity = 100;
        T[] items = new T[Capacity];
        public void Add(T value)
        {

            T[] numbers = new T[Capacity * 2];
            for(int i = 0; i<Count; i++)
            {
                numbers[i] = items[i];
            }
           numbers[count] = value;
            count++;
            items=numbers;
        }
         public void Remove(T value)
         {
            for(int i=0; i<Count;i++)
            {
               if( data[i].Equals( value))
               {
                    count--;
               }
            }


         }
    
    }
        
    

    

}
