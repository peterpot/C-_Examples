using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessibility
{
    class Program 
    {
        static void Main(string[] args)
        {
            Car c = new Car();            
            ConvertibleCar c2 = new ConvertibleCar();
            List<Car> cars = new List<Car>() { c, c2 };
            foreach(var car in cars)
            {
                car.StartEngine();
            }


            Car cZnamka = new Car("Saab");
            ConvertibleCar ConvertibleCar = new ConvertibleCar("Saab");


            Console.ReadKey();
        }
    }

    public class Car
    {
        public Car()
        {
            Console.WriteLine("Car constructor created");
        }

        public Car(string znamka) 
        {
            Console.WriteLine("Car constructor created for " + znamka);
        }
        
        private string privVar { get; set; } = "private var";           // accessible in the class 
        protected string protectedVar { get; set; } = "protected var";  // accessible in the class or derived class
        internal string internalVar { get; set; } = "internal var";     // accessible in the assembly


        // PROTECTED VIRTUAL:
        public virtual void StartEngine()
        {
            Console.WriteLine(privVar);
            Console.WriteLine("engine started from virtual");
        }

        protected virtual void StopEngine()
        {
            Console.WriteLine("engine stopped from virtual");
        }
    }

    public class ConvertibleCar : Car
    {
        public ConvertibleCar() 
        {
            Console.WriteLine("ConvertibleCar constructor created");
            Console.WriteLine(protectedVar);

            protectedVar = "protectedVat setted in ConvertibleCar";
            internalVar = "internalVar setted in ConvertibleCar";       
        }

        public ConvertibleCar(string znamka) : base(znamka)
        {
            Console.WriteLine("ConvertibleCar constructor created for " + znamka);
        }

        public override void StartEngine()
        {
            Console.WriteLine("engine started from override");
        }

        protected override void StopEngine()
        {
            Console.WriteLine("engine stopped from override");
        }

    }

    // ======
    // SEALD:
    // ======

    // --------
    // CLASSES:
    // --------
    class Car1 { }
    sealed class Car2 : Car1 { }
    // class Car3 : Car2 { }  // You can't derived from seald class 


    // -------
    // METHODS:
    // --------
    class X
    {
        protected virtual void F() { Console.WriteLine("X.F"); }
        protected virtual void F2() { Console.WriteLine("X.F2"); }
    }
    class Y : X
    {
        // only for "override" methods:
        sealed protected override void F() { Console.WriteLine("Y.F"); }
        protected override void F2() { Console.WriteLine("Y.F2"); }
    }
    class Z : Y
    {
        // Attempting to override F causes compiler error CS0239.
        // protected override void F() { Console.WriteLine("C.F"); }

        // Overriding F2 is allowed.
        protected override void F2() { Console.WriteLine("Z.F2"); }
    }
}
