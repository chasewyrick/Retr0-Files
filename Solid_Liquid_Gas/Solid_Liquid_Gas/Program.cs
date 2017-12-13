using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Liquid_Gas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter current temperature of water in degress celsius: ");
            int temp = int.Parse(Console.ReadLine());

            if (temp <= 0)
            {
                Console.Write("It is a solid.");
            }
            else if (temp >= 100)
            {
                Console.Write("It is a gas.");
            }
            else
            {
                Console.Write("It is a liquid.");
            }

            Console.ReadLine();
        }
    }
}
