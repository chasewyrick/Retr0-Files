using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many kitties do you have?: ");
            int kitties = int.Parse(Console.ReadLine());

            Console.Write("Each person gets " + (kitties / 4) + " net kitties.");

            Console.ReadLine();
        }
    }
}
