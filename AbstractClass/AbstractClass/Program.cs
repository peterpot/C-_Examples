using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new SporsCar("Porsche");
            Car car2 = new ComfortableCar("Mercedes");

            Console.WriteLine(car.Name);
            Console.WriteLine(car2.Name);
            Console.ReadKey();
        }
    }

    class SporsCar : Car
    {
        public SporsCar(string name) : base(name)
        { }

        public int HorsePower { get; set; }
    }

    class ComfortableCar : Car
    {
        public ComfortableCar(string name) : base(name)
        { }

        public int NumOfSeats { get; set; }
    }

    abstract class Car 
    {
        public Car(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
