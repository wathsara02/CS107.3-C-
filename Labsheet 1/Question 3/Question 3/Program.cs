using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Enter a number to calculate the sum: ");
            int i=int.Parse(Console.ReadLine());

            if(i<0) 
            {
                Console.WriteLine("Error! The number should be a positive number");
            }
            else if(i==0)
            {
                Console.WriteLine("The sum is 0");
            }
            else 

            {
                for(int j=0; j<=i; j++) 
                {
                    total = total + j;
                }
                Console.WriteLine("The total is " + total);
                
            }
            Console.ReadLine();
        }
    }
}
