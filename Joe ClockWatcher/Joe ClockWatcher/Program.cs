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

            int endMin = 960;
            int hour = Time / 100;
            int minutes = Time % 100;

            minutes = minutes + (hour * 60);

            int timeleft = endMin - minutes;
            int hoursleft = timeleft / 60;
            int minutesleft = timeleft % 60;

            Console.Write("Hours: " + hoursleft + " Minutes: " + minutesleft);


            Console.Read();
        }
    }
}