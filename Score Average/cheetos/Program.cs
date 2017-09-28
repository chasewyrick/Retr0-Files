using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cheetos
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1, s2, s3,total;

            Console.Write("Score One: ");
            s1 = double.Parse(Console.ReadLine());
            Console.Write("Score Two: ");
            s2 = double.Parse(Console.ReadLine());
            Console.Write("Score Three: ");
            s3 = double.Parse(Console.ReadLine());

            total = (s1 + s2 + s3) / 3;

            Console.Write("Average: " + total);

            Console.ReadLine();
        }
    }
}
