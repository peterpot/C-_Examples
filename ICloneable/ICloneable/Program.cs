using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Car car = new Car();
            car.Name = "Saab";

            Car car2 = (Car)car.Clone();
            car2.Name = "Porsche";

            Console.WriteLine(car.Name);
            Console.WriteLine(car2.Name);
            Console.ReadKey();
        }
    }

    class Car : System.ICloneable
    {
        public string Name { get; set; }

        public object Clone()
        {
            return new Car { Name = Name };
        }
    }
}
