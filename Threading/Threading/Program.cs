using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;

            Console.WriteLine(Thread.GetDomain().DynamicDirectory);

            Console.ReadKey();
        }
    }
}
