using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Give a number: ");

            string line = Console.ReadLine();
            num = int.Parse(line);

            for(int i = 0;i < num;i ++)
            {
                for(int j = -1;j < i;j++)
                    Console.Write("*");
                    Console.WriteLine(); 
            }
        }
    }
}
