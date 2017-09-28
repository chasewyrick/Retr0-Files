using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ronald_mcdonald
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Paycheck: ");
            double paycheck = double.Parse(Console.ReadLine()), tax = paycheck * .20, aftertax = paycheck - tax;

            Console.WriteLine(" ");
            Console.WriteLine("Tax Total: $" + tax);
            Console.WriteLine("After Tax Total: $" + aftertax);

            Console.ReadLine();
        }
    }
}
