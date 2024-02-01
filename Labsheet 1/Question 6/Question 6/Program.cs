using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the exam marks :");
            int marks = int.Parse(Console.ReadLine());


            if (marks > 100)
                Console.WriteLine("Invalid Marks!");

            else if (marks >= 75)
            { Console.WriteLine(name +" got a 'A' Pass "); }

            else if (marks >= 60)
            { Console.WriteLine(name + " got a 'B' Pass "); }

            else if (marks >= 50)
            { Console.WriteLine(name + " got a 'C' Pass "); }

            else if (marks >= 40)
            { Console.WriteLine(name + " got a 'd' Pass "); }

            else if (marks >= 0)
            { Console.WriteLine(name + " Failed the exam "); }

            else 
            {Console.WriteLine("Invalid Marks"); }

            Console.ReadLine();
        }
        
    }
}
