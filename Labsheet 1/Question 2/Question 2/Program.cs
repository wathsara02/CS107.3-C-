using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
                while (i < 11)
            {
                Console.WriteLine("Enter number " + i +":");
                int j =int.Parse(Console.ReadLine());
                if(j%2==0) 
                {
                    Console.WriteLine("The number " + j + " is an even number\n");
                }
                else { Console.WriteLine("The number " + j + " Is an odd number\n");
                    i++;
                }
            }
        }
    }
}
