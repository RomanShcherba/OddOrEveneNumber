using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number:");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input. Please enter integer.");
                    Console.Write("Enter a number: ");
                }
            string[] message = { "Even number.", "Odd number." };
            Console.WriteLine(message[number & 1]);
        }
    }
}
