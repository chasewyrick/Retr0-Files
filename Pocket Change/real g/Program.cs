using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace real_g
{
    class Program
    {
        static void Main(string[] args)
        {
            double quarters, dimes, nickels, pennies;
            double qTotal, dTotal, nTotal, pTotal;

            Console.Write("Enter amnt. of Quarters: ");
            quarters = double.Parse(Console.ReadLine());
            Console.Write("Enter amnt. of Dimes: ");
            dimes = int.Parse(Console.ReadLine());
            Console.Write("Enter amnt. of Nickels: ");
            nickels = int.Parse(Console.ReadLine());
            Console.Write("Enter amnt. of Pennies: ");
            pennies = int.Parse(Console.ReadLine());

            qTotal = quarters * .25;
            dTotal = dimes * .10;
            nTotal = nickels * .05;
            pTotal = pennies * .01;

            double Total = qTotal + dTotal + nTotal + pTotal;

            Console.WriteLine("Total: $" + Total);


            //I AM A MEXICAN

            Console.ReadLine();
        }
    }
}
