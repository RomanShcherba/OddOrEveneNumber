using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            string[] message = { "Even number.", "Odd number." };

            Console.WriteLine(message[number & 1]);
        }
    }
}
