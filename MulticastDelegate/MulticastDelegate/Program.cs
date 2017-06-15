using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    delegate void CustomDel(string s);

    class Program
    {
        static void Main(string[] args)
        {
            CustomDel hiDel, byeDel, multiDel, multiMinusHiDel;

            hiDel = Hello;

            byeDel = Goodbye;

            multiDel = hiDel + byeDel;            // ADD 2 DELEGATES!

            multiMinusHiDel = multiDel - hiDel;   // REMOVE DELEGATE!

            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("A");
            Console.WriteLine("Invoking delegate byeDel:");
            byeDel("B");
            Console.WriteLine("Invoking delegate multiDel:");
            multiDel("C");
            Console.WriteLine("Invoking delegate multiMinusHiDel:");
            multiMinusHiDel("D");

            Console.ReadKey();

        }

        static void Hello(string s)
        {
            System.Console.WriteLine("  Hello, {0}!", s);
        }

        static void Goodbye(string s)
        {
            System.Console.WriteLine("  Goodbye, {0}!", s);
        }
    }


}
