using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    public class TemperatureTracker
    {
        private double[] temperatures = new double[7];

        public void InputTemperatures()
        {
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.Write("Enter temperature for day " + (i + 1) + ": ");
                temperatures[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void DisplayTemperatures()
        {
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine("Temperature for day " + (i + 1) + ": " + temperatures[i]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker tracker = new TemperatureTracker();
            tracker.InputTemperatures();
            tracker.DisplayTemperatures();
            Console.ReadKey();
        }
    }
}
