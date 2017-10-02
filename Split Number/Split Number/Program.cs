using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Number: ");
            int tard = int.Parse(Console.ReadLine());

            int bigger = tard / 100;
            int weird = tard % 100;
            int medium = weird / 10;
            int small = weird % 10;

            Console.WriteLine(bigger + medium + small);


            Console.ReadLine();
        }
    }
}
