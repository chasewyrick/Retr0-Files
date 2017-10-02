using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joe_ClockWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Current Time: ");
            int Time = int.Parse(Console.ReadLine());

            int shiftleft = 1600 - Time;
            int hour = shiftleft / 100;
            int minutes = shiftleft % 100;

            Console.Write("Hours: " + hour + " Minutes: " + minutes);


            Console.Read();
        }
    }
}