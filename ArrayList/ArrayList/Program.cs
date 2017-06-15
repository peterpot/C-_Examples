using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Collections;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList arList = new System.Collections.ArrayList();
            arList.Add(15);
            arList.Add("item");

   

            foreach(var item in arList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

