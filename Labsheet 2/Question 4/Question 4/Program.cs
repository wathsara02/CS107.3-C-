using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Apple", 0.75m);
            Product product2 = new Product("Banana", 0.50m);

            Console.WriteLine("Product 1 Details:");
            Console.WriteLine("Name: " + product1.ProductName);
            Console.WriteLine("Price: " + product1.Price);

            Console.WriteLine("Product 2 Details:");
            Console.WriteLine("Name: " + product2.ProductName);
            Console.WriteLine("Price: " + product2.Price);
            Console.ReadLine();
        }
    }
}
