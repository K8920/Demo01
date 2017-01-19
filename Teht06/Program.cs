using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            int matka;
            double litra = 7.02 / 100;
            double hinta = 1.595;

            Console.WriteLine("Matka? ");
            string line = Console.ReadLine();
            matka = int.Parse(line);

            litra = (litra * matka);
            hinta = (litra * hinta);
            Console.WriteLine("Bensaa kuluu: " +  litra);
            Console.WriteLine("Kustannus: " + hinta);
        }
    }
}
