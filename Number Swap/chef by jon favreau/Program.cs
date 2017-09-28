using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chef_by_jon_favreau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first integer: ");
            int jedi = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int sith = int.Parse(Console.ReadLine());
            Console.Write(" ");
            Console.Write(jedi + "\t" + sith);

            int temp;
            temp = jedi;
            jedi = sith;
            sith = temp;

            Console.WriteLinea(" ");
            Console.Write(jedi + "\t" + sith);


            Console.ReadLine();
        }
    }
}
