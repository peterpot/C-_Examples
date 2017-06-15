using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Long?");

            int intValue = 999999999;
            long longValue = 999999999999999999;            
            decimal decMoneyValue2 = 9999999999999999999999999999m; 
            double doubValue2 = 999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999d;
            float floatValue2 = 99999999999999999999999999999999999999f;            
            Console.WriteLine(intValue);
            Console.WriteLine(longValue);
            Console.WriteLine(decMoneyValue2);  
            Console.WriteLine(doubValue2);      
            Console.WriteLine(floatValue2);


            Console.WriteLine("How Precise?");

            decimal decMoneyValue = 1.5555555555555555555555555555555m; // For finance (much slower)
            double doubValue = 1.55555555555555555555;                  // For scientific (fastes - binary)
            float floatValue = 1.5555555555555f;                        // For scientific (fastes - binary)
            Console.WriteLine(decMoneyValue);  // se zaokrozi pri "28-29 digits"
            Console.WriteLine(doubValue);      // se zaokrozi pri "15-16 digits"
            Console.WriteLine(floatValue);     // se zaokrozi pri "7 digits"

            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3;
            Console.WriteLine("float: {0} double: {1} decimal: {2}", flt, dbl, dcm);

            Console.ReadKey();
        }
    }
}
