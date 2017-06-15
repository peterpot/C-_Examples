using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTrip<ICar> trip = new MyTrip<ICar>();
            trip.Go(new Saab());
            trip.Go(new Porsche());

            
            Console.ReadKey();
        }
    }
}

public interface ICar 
{
    void Drive();
}


public class Saab : ICar
{
    public void Drive()
    {
        Console.WriteLine("Drive Saab");
    }
}

public class Porsche : ICar
{
    public void Drive()
    {
        Console.WriteLine("Drive Porsche");
    }
}

public class MyTrip<T> where T: ICar
{
    public void Go(T t)
    {
        ICar car = t;
        car.Drive();
    }
}




