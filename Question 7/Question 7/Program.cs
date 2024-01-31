using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the choice of service :\n 1.Check the balance \n 2.Deposit money \n 3.Withdraw money \n 4.Exit");
            int choice = int.Parse(Console.ReadLine());
            double AccBal = 10000;

            switch (choice)
            {
                case 1:
                    Balance();
                    break;

                case 2:
                    Deposit();
                    break;

                case 3:
                    Withdraw();
                    break;

                case 4:
                    Exit();
                    break;

                default:
                    Console.WriteLine("Wrong option choose again");
                    break;
            }
                   

            void Balance() 
            {
                Console.WriteLine("Your Balance is Rs."+AccBal);
            }

            void Deposit () 
            { Console.WriteLine("Enter the amount to deposit and insert the cash.");
                double depoamount = int.Parse(Console.ReadLine());
                AccBal = AccBal + depoamount;
                Console.WriteLine("Your deposit is complete.\nYour new balance is " + AccBal);
            }

            void Withdraw ()
            { Console.WriteLine("Enter the amount to withdraw :Rs");
                    double withamount= int.Parse(Console.ReadLine()); 
            if (withamount<= AccBal)
                {
                    Console.WriteLine("Withdraw is processing");
                        AccBal = AccBal - withamount;
                    Console.WriteLine("Withdraw is completed,Your new balance is  " + AccBal);
                }
                else
                {
                    Console.WriteLine("Invalid Amount.The requested withdraw amount is more than the available balance\nPlease try again");
                    Withdraw();
                }



            }
            void Exit()
            { }
            Console.ReadLine();
        }
    }
}
