using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captain_Jack
{
    class Program
    {
        static void Main(string[] args)
        {
            int jack, gilligan, crew, PBA,temp_gold;

            Console.Write("How much did the pirate ship come into the port with? ");
            int init_gold = int.Parse(Console.ReadLine());
            Console.Write("How many pirates are on the ship? (Including Jack & Gilligan)? ");
            int crew_members = int.Parse(Console.ReadLine());

            init_gold = init_gold - ((crew_members - 2) * 3);
            crew = ((crew_members - 2) * 3) / (crew_members - 2);
            // init_gold = 70; crew = 3

            jack = (int)(init_gold * .12);
            init_gold = (int)(init_gold - (int)(init_gold * .12));
            // init_gold = 62; jack = 8
            

            gilligan = (int)(init_gold * .08);
            init_gold = (int)(init_gold - (int)(init_gold * .08));
            // init_gold = 58; gilligan = 4

            temp_gold = (int)(init_gold / crew_members); // == 4

            jack = jack + temp_gold;
            gilligan = gilligan + temp_gold;
            crew = crew + temp_gold;
            //each member gets 4, crew = 7; jack = 12; gilligan = 8

            init_gold = (int)(init_gold - ((init_gold / crew_members) * crew_members));

            PBA = init_gold;

            Console.WriteLine(" ");
            Console.WriteLine("Jack: " + jack);
            Console.WriteLine("Gilligan: " + gilligan);
            Console.WriteLine("Crew: " + crew);
            Console.WriteLine("PBA: " + PBA);

            Console.Read();
        }
    }
}