using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit_to_Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter # in Fahrenheit: ");
            int fahrenheit = int.Parse(Console.ReadLine());
            int c = ((fahrenheit - 32) * 5) /9;

            Console.Write("Celsius: " + c);


            Console.ReadLine();
        }
    }
}
