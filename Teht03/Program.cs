using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, sum, avrg;
            Console.WriteLine("Give three numbers: ");
            string line1 = Console.ReadLine();
            num1 = int.Parse(line1);
            string line2 = Console.ReadLine();
            num2 = int.Parse(line1);
            string line3 = Console.ReadLine();
            num3 = int.Parse(line1);

            sum = num1 + num2 + num3;
            avrg = ((num1 + num2 + num3) / 3);
            Console.WriteLine(sum);
            Console.WriteLine(avrg);
        }
    }
}
