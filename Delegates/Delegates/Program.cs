using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            // ===========
            // DELETAGES:
            // ===========
            
            // ADD METHODS TO THE DELEGATE:
            MyDelegate del = Add;
            del += Multiply;
            del += Devide;

            // EXECUTE DELEGATE:
            del(20, 10);

            // ==========
            // INTERFACE:
            // ==========
            List<ICalculate> calcList = new List<ICalculate>()
            {
                new Add(),
                new Multiply(),
                new Devide()
            };

            new RunCalculation(calcList, 20, 10);


            Console.ReadKey();
        }

        public static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public static void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        public static void Devide(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }

    // ==================
    // INTERFACE SOLUTION:
    // ==================

    public class RunCalculation
    {
        public RunCalculation(List<ICalculate> calcList, int x, int y)
        {
            foreach(var c in calcList)
            {
                c.Calculate(x, y);
            }
        }
    }
    
    public interface ICalculate
    {
        void Calculate(int x, int y);
    }

    public class Add : ICalculate
    {
        public void Calculate(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }

    public class Multiply : ICalculate
    {
        public void Calculate(int x, int y)
        {
            Console.WriteLine(x * y);
        }
    }

    public class Devide : ICalculate
    {
        public void Calculate(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }

}
