using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5;
            string line1 = Console.ReadLine();
            num1 = int.Parse(line1);

            string line2 = Console.ReadLine();
            num2 = int.Parse(line2);

            string line3 = Console.ReadLine();
            num3 = int.Parse(line3);

            string line4 = Console.ReadLine();
            num4 = int.Parse(line4);

            string line5 = Console.ReadLine();
            num5 = int.Parse(line5);

            int[] array = new int[5] { num1, num2, num3, num4, num5 };
            //Array.Reverse(array);
            Console.WriteLine("-----------------");

            for (int i = 0; i > array[5]; i++)
            {
                for (int j = 0; j = array[5]; j--)

                    foreach (int item in array)
                    {
                        Console.WriteLine(item.ToString());
                    }
            }
        }
    }
}
