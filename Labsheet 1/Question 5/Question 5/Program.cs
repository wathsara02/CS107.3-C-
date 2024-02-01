using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to get the multiplication table");
            int number=int.Parse(Console.ReadLine());
            Console.WriteLine("Multiplication table of number " + number +" is:");

            for(int i = 1; i < 13; i++)
            {
                Console.WriteLine(number*i);
            }
            Console.ReadLine();
        }
    }
}
