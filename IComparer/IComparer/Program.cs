using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Collections;

namespace IComparerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>()
            {
                new Car() {name = "Saab", year = 2004 },
                new Car() {name = "Audi", year = 2016 },
                new Car() {name = "BMW", year = 2015 }                
            };


            carList.Sort(new sortYearDescendingHelper());
            foreach(var c in carList)
            {
                Console.WriteLine(c.year);
            }


            carList.Sort(new sortMakeDescendingHelper());
            foreach (var c in carList)
            {
                Console.WriteLine(c.name);
            }

            carList.Reverse();
            foreach (var c in carList)
            {
                Console.WriteLine(c.name);
            }

            Console.ReadKey();
        }
    }

    public class Car
    {
        public string name { get; set; }
        public int year { get; set; }
    }


    public class sortYearDescendingHelper : IComparer<Car>
    {
        public int Compare(Car c1, Car c2)
        {
            if (c1.year < c2.year)
                return 1;

            if (c1.year > c2.year)
                return -1;

            else
                return 0;
        }
    }

    public class sortMakeDescendingHelper : IComparer<Car>
    {
        public int Compare(Car c1, Car c2)
        {
            // descending
            return String.Compare(c2.name, c1.name);
        }
    }
}
