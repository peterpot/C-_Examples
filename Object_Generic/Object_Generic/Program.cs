using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            var carOb = GetObject() as Car;
            Console.WriteLine(carOb.Id);
            Console.WriteLine(carOb.Name);

            var carDynamic = GetDynamic();
            Console.WriteLine(carDynamic.Id);
            Console.WriteLine(carDynamic.Name);

            Console.ReadKey();
        }

        public static object GetObject()
        {
            var car = new Car { Id = 1, Name = "Porsche" };

            return car;
        }

        public static dynamic GetDynamic()
        {
            var car = new Car { Id = 1, Name = "Porsche" };

            return car;
        }

        public class Car
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
