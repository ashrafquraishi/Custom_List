using Custom_list_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customlistclass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> testList = new CustomList<int>();
          //  CustomList<int> testList2 = new CustomList<int>();
            //  CustomList<int> answer = testList + testList2;
            testList.Add(8);
            testList.Add(12);
            testList.Add(8);
            testList.Add(12);
            testList.Add(8);
            testList.Add(12); testList.Add(8);
            testList.Add(12);
            testList.Add(8);
            testList.Add(12);
            testList.Add(8);
            testList.Add(12);
            testList.Add(8);
            testList.Add(12); testList.Add(8);
            testList.Add(12); testList.Add(8);
            testList.Add(12);
            testList.Add(8);
            testList.Add(12);
            testList.Add(8);
            testList.Add(12); testList.Add(8);
            testList.Add(12);
        }
    }
}
