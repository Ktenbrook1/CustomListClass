using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(5);
            customList.Add(2);
            customList.Add(4);
            customList.Add(8);
            customList.Add(6);
            customList.Add(5);

            string test =  customList.ToString();
        }
    }
}
