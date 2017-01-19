using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
            Console.WriteLine("Anna kolme lukua: ");

            string line1 = Console.ReadLine();
            luku1 = int.Parse(line1);
            string line2 = Console.ReadLine();
            luku2 = int.Parse(line2);
            string line3 = Console.ReadLine();
            luku3 = int.Parse(line3);

            if (luku1 > luku2 && luku1 > luku3)
            {
                Console.WriteLine("Luku1 on suurin " + luku1);
            }

            else if(luku2 > luku1 && luku2 > luku3)
            {
                Console.WriteLine("Luku2 on suurin " + luku2);
            }
            else if (luku3 > luku1 && luku3 > luku2)
            {
                Console.WriteLine("Luku3 on suurin " + luku3);
            }
            else
            {
                Console.WriteLine("Väh. kaksi lukua on sama ");
            }
        }
    }
}
