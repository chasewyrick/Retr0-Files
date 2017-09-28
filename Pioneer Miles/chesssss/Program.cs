using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chesssss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter wheel diameter: ");
            double diameter = double.Parse(Console.ReadLine());
            Console.Write("Rotations: ");
            double rotations = double.Parse(Console.ReadLine());

            double frickyou = ((diameter * 3.14151926535897932384626433) * rotations) / 5280;

            Console.Write("Miles: " + frickyou);

            Console.ReadLine();
        }
    }
}
