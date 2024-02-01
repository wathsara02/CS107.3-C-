using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle");
            int length=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of the rectangle is " + length * width);
            Console.ReadLine();
        }
    }
}
