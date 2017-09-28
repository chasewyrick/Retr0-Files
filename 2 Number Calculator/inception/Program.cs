using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inception
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.Write("Enter first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Numbers {0} and {1}", num1, num2);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Addition: " + (num1 + num2));
            Console.WriteLine("Subtraction: " + (num1 - num2));
            Console.WriteLine("Multiplication: " + (num1 * num2));
            Console.WriteLine("Division: " + (num1 / num2));

            Console.ReadLine();
        }
    }
}
