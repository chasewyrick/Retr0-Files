using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken_Coop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius: ");
            double radius = double.Parse(Console.ReadLine());

            double circle = (3.1415 * radius * radius);
            double SBase = radius * 2;
            double SHeight = radius * 2;
            double square_area = SBase * SHeight;

            Console.Write("Area: " + (square_area - circle));

            Console.ReadLine();
        }
    }
}
