using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ronald_Tax_Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Earned Net Kitties: ");
            int total_kit = int.Parse(Console.ReadLine());
            Console.Write("Enter Tax Rate: ");
            double taxRate = double.Parse(Console.ReadLine());

            int netKit = (int)(total_kit * taxRate);

            Console.Write("The Net Kitties are: " + netKit);

            Console.Read();
        }
    }
}
