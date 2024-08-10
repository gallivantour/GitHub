using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition Calculator");

            // Ask user to input 1st number
            Console.Write("Input the 1st number:");
            int a = Convert.ToInt32(Console.ReadLine());

            // ask user to input 2nd number
            Console.Write("imput 2nd number:");
            int b = Convert.ToInt32(Console.ReadLine());

            //calculation
            int sum = a * b;
            
            
            Console.WriteLine($"sum of your numbers is {sum}");
            Console.Read();
        }
    }
}
