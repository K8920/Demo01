using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi;
            Console.WriteLine("Vuosi? ");
            string line = Console.ReadLine();
            vuosi = int.Parse(line);

            if (vuosi % 400 == 0)
            {
                Console.WriteLine("Karkausvuosi");
            }

            else if (vuosi % 4 == 0 && vuosi % 100 == 0)
            {
                Console.WriteLine("Ei karkausvuosi");
            }

            else if (vuosi % 4 == 0)
            {
                Console.WriteLine("Karkausvuosi");
            }

            else if (vuosi % 4 >= 1)
            {
                Console.WriteLine("Ei karkausvuosi");
            }
            
            
        }
    }
}
