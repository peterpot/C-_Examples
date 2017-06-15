using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = new SportsCar();
            SportsCar sportsCar2 = new SportsCar();


            Console.WriteLine(car.GetSpeed());
            Console.WriteLine(car.GetSeats());

            Console.WriteLine(car2.GetSpeed());
            Console.WriteLine(car2.GetSeats());

            Console.WriteLine(sportsCar2.GetSpeed());
            Console.WriteLine(sportsCar2.GetSeats());            
            Console.WriteLine(sportsCar2.GetHorsePower());


            Console.ReadKey();

        }
    }

    class Car
    {
        public virtual int GetSpeed()
        {
            return 180;
        }

        public int GetSeats()
        {
            return 5;
        }
    }

    class SportsCar : Car
    {
        public override int GetSpeed()
        {
            return 220;
        }

        public int GetHorsePower()
        {
            return 320;
        }
    }
}
