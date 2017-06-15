using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    public delegate void myGenericDelegate<T>(T arg);

    class Program
    {
        static void Main(string[] args)
        {
            myGenericDelegate<string> del = new myGenericDelegate<string>(StrTarget);
            myGenericDelegate<int> del2 = new myGenericDelegate<int>(IntTarget);

            del("5");
            del2(2);
            Console.ReadKey();
        }


        static void IntTarget(int arg)
        {
            Console.WriteLine(arg);
        }

        static void StrTarget(string arg)
        {
            Console.WriteLine(arg);
        }
    }
}
