using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_vs_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new MyCar();
            car.Drive();
            car.GearBox();
            car.Accelarate();
            car.OpenRoof();

            Console.ReadKey();
        }
    }

    public abstract class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public abstract string Model { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Drive");
        }

        public abstract void GearBox();
    }

    public abstract class SportCar : Car
    {
        public virtual void Accelarate()
        {
            Console.WriteLine("Accelarate!");
        }
    }

    public interface IConvertible
    {
        void OpenRoof();

    }
    
    public class MyCar : SportCar, IConvertible
    {
        public override string Model { get; set; }
        public override void GearBox()
        {
            Console.WriteLine("Tip tronic!");
        }

        public void OpenRoof()
        {
            Console.WriteLine("Open roof!");
        }
    }
}
