using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string myTestString = "Peter";
            Console.WriteLine(myTestString.ToMyCustomString());

            var products = new Product[]
            {
                new Product { Price = 10 },
                new Product { Price = 5 },
                new Product { Price = 3 }
            };
            Console.WriteLine(products.TotalPrice());
            
            Console.ReadKey();
        }
    }

    public static class myExtensionMethod
    {
        public static String ToMyCustomString(this String item)
        {
            return "This is custom string " + item;
        }

        public static decimal TotalPrice(this IEnumerable<Product> items)
        {
            decimal total = 0;
            foreach(var product in items.FilterProducts(p => p.Price > 3))
            {
                total += product.Price;
            }
            return total;
        }

        public static IEnumerable<Product>FilterProducts(this IEnumerable<Product> items, Func<Product, bool> isSelected)
        {
            foreach(Product p in items)
            {
                if (isSelected(p))
                    yield return p;
            }
        } 
    }

    public class ShopingCart : IEnumerable<Product>
    {
        public List<Product> Products { get; set; }

        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
