using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joe_Changeless
{
    class Program
    {
        static void Main(string[] args)
        {
            int change;

            Console.Write("Enter Change in Cents: ");
            change = int.Parse(Console.ReadLine());

            int quarters = change / 25;
            change = change % 25;

            int dime = change / 10;
            change = change % 10;

            int nickels = change / 5;
            change = change % 5;

            int penny = change;

            Console.WriteLine(quarters + " quarters");
            Console.WriteLine(dime + " dimes");
            Console.WriteLine(nickels + " nickels");
            Console.WriteLine(penny + " pennies");


            Console.ReadLine();
        }
    }
}
