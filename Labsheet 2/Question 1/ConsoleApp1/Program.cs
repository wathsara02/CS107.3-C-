using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {        
        public string Title { get; set; }
        public string Author { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book mybook = new Book();
            mybook.Title = "C# Programming";
            mybook.Author = "John Doe";
            Console.WriteLine("Title: " + mybook.Title);
            Console.WriteLine("Author: " + mybook.Author);
            Console.ReadLine();
        }
    }
}
