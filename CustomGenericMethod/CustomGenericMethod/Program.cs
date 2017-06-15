using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Swap(5, 10);
        }

        static void Swap<T>(T x,  T y)
        {
            Console.WriteLine(x + " - " + y);

            T temp;
            temp = x;
            x = y;
            y = temp;

            Console.WriteLine(x + " - " + y);

            Console.ReadKey();           
        }       
    }
}
