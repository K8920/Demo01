using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            Console.WriteLine("Give some numbers: ");

            do
            {
                
                string line = Console.ReadLine();
                num = int.Parse(line);

                sum = sum + num;
            } while (num > 0);
            Console.WriteLine(sum);
        }
    }
}
