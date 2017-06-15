using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    class Program
    {
        static void Main(string[] args)
        {
            var carList = new List<ICar>() { new Car() };

            foreach (var c in carList)
            {
                c.Drive(0);
                c.Drive(1);
                c.Drive(2);
                c.Drive(3);
                c.Drive(4);
                c.Drive(5);
                c.Drive(6);

            }
            Console.ReadKey();
        }
    }

    interface ICar
    {
        int Drive(int gear);
    }

    class Car : ICar
    {
        public virtual int Drive(int gear)
        {
            // --------------
            // PRE-CONDITIONS:
            // --------------

            if (gear > 6)
                throw new ArgumentOutOfRangeException("max gear is 6!");

            Console.WriteLine("drive car in {0} gear!", gear);

            gear ++;

            // --------------
            // POST-CONDITIONS:
            // --------------
            if (gear > 6 || gear < 0)
                return gear;
            else
                return -1;
        }
    }

    class SportCar : Car
    {
        public override int Drive(int gear)
        {
            // --------------
            // PRE-CONDITIONS:
            // --------------

            if (gear > 6)
                throw new ArgumentOutOfRangeException("max gear is 6!");

            // STRENGHTEN PRECONDITION - "CONFLICT LISKOV!!!"
            if (gear < 1)
                throw new ArgumentOutOfRangeException("min gear is 1!");
            // ==========================================================

            Console.WriteLine("drive sports car in {0} gear!", gear);

            gear ++;

            // --------------
            // POST-CONDITIONS:
            // --------------
            // WEAKEN POSTCONDITION - "CONFLICT LISKOV!!!"
            if (gear <= 6)
                return gear;
            else
                return -1;
            // ============================================
        }
    }
}
