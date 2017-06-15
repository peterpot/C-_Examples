using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //Car car2 = new Car();

            Car car = new Car("Saab");
            car.Name = "Saab";
            Car car2 = new Car("Porsche");

            Console.WriteLine(Car.StaticName);
            Console.WriteLine(Car.StaticName2);
            Console.WriteLine(car.Name);


            Console.ReadKey();
        }
    }

    public class Car
    {
        public static string StaticName { get; set; }
        public static string StaticName2 { get; set; }
        public string Name { get; set; }

        static Car() {
            StaticName = "Audi";
        }
        

        public Car(string name)
        {
            StaticName = name;
            StaticName2 = "Audi";
        }
    }
}
