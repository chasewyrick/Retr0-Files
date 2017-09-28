using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audi
{
    class Program
    {
        static void Main(string[] args)
        {
            string jedi, sith, tempWarrior;

            Console.Write("Enter a word to swap: ");
            jedi = Console.ReadLine();
            Console.Write("Enter a 2nd word to swap: ");
            sith = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine(jedi + "\t" + sith);

            tempWarrior = jedi;
            jedi = sith;
            sith = tempWarrior;

            Console.WriteLine(jedi + "\t" + sith);

            Console.ReadLine();
        }
    }
}
