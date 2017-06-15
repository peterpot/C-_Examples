using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_Composition_Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {   
            Association assoc = new Association();
            assoc.Initiate(new Car());

            // WHEN DISPOSING:
            // - Aggregate and Car are disposed!
            Compositon comp = new Compositon();
            comp.Initiate();


            // WHEN DISPOSING:
            // - Aggregate is disposed - Car is still live!
            Aggregation agr = new Aggregation(new Car());
            agr.Initialize();

            Console.ReadKey();      
         }
    }
}


public class Car
{
    public void Drive()
    {
        Console.WriteLine("drive car!");
    }
}


// Association - I have a relationship with an object.Foo uses Bar
public class Association
{
    public void Initiate(Car c)
    {
        c.Drive();
    }
};

// Composition - I own an object and I am responsible for its lifetime, when Foo dies, so does Bar
public class Compositon
{
    private Car c = new Car();
    
    public void Initiate()
    {
        c.Drive();
    }
}
// Aggregation - I have an object which I've borrowed from someone else. When Foo dies, Bar may live on.
public class Aggregation
{
    private Car c;

    public Aggregation(Car c)
    {
        this.c = c;
    }

    public void Initialize()
    {
        c.Drive();
    }
}


