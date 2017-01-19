using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec = 0, hr = 0, min = 0;
            Console.WriteLine("Seconds? ");
            string line = Console.ReadLine();
            sec = int.Parse(line);

            hr = sec / 3600;
            min = (sec % 3600) / 60;
            sec = (sec % 3600) % 60;

            Console.WriteLine("Hours: {0} Minutes: {1} Seconds: {2}", hr, min, sec);
        }
    }
}
