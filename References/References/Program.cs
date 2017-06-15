using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References
{
    class Program
    {
        static void Main(string[] args)
        {
            string strValue = "Value 1";
            Car c = new Car();
            c.Id = 1;
            c.Name = "BMW";

            List<Car> list = new List<Car>();
            list.Add(c);

            Car c2 = new Car();
            c2 = c;
            string strValue2 = strValue;
            strValue2 = "value 2";

            c2.Id = 2;
            c2.Name = "Audi";

            Console.WriteLine(c.Id);
            Console.WriteLine(c.Name);

            Console.WriteLine(c2.Id);
            Console.WriteLine(c2.Name);

            foreach(var car in list)
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.Name);
            }

            Console.WriteLine(strValue);
            Console.WriteLine(strValue2);

            Console.ReadKey();
        }
    }
    
    class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
