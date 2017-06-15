using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Collections;

namespace IEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage g = new Garage();
            System.Collections.IEnumerator i = g.GetEnumerator();
            i.MoveNext();
            Car car = (Car)i.Current;
            Console.WriteLine(car.ToString());
            i.MoveNext();
            car = (Car)i.Current;
            Console.WriteLine(car.ToString());

            // GET ENUMERATOR CUSTOM:
            System.Collections.IEnumerator i2 = g.GetEnumeratorCustom();
            i2.MoveNext();
            Car car2 = (Car)i2.Current;
            Console.WriteLine(car2.Name);
            i2.MoveNext();
            car2 = (Car)i2.Current;
            Console.WriteLine(car2.Name);

            // GET ENUMERATOR REVERSE:
            System.Collections.IEnumerator i3 = g.GetEnumeratorReverse();
            i3.MoveNext();
            Car car3 = (Car)i3.Current;
            Console.WriteLine(car3.Name);
            i3.MoveNext();
            car3 = (Car)i3.Current;
            Console.WriteLine(car3.Name);

            Console.ReadKey();
        }
    }

    class Car
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return "Selected car is: " + Name;
        }
    }

    class Garage : IEnumerable
    {
        private Car[] cars = new Car[]
        {
            new Car { Name = "Saab" },
            new Car { Name = "Audi" },
            new Car { Name = "Porsche" }
        };

        public Garage ()
        {

        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        public System.Collections.IEnumerator GetEnumeratorCustom()
        {
            foreach(Car c in cars)
            {
                yield return c;
            }
        }

        public System.Collections.IEnumerator GetEnumeratorReverse()
        {
            for (int i = cars.Length; i != 0; i--)
            {
                yield return cars[i-1];
            }
        }
    }
}
