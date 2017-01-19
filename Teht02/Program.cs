using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            int point, grade = 0;
            Console.WriteLine("Point: ");
            string line = Console.ReadLine();
            point = int.Parse(line);

            if (point == 0 || point == 1)
            {
                grade = 0;
                Console.WriteLine(grade);
            }
            else if (point == 2 || point == 3)
            {
                grade = 1;
                Console.WriteLine(grade);
            }
            else if (point == 4 || point == 5)
            {
                grade = 2;
                Console.WriteLine(grade);
            }
            else if (point == 6 || point == 7)
            {
                grade = 3;
                Console.WriteLine(grade);
            }
            else if (point == 8 || point == 9)
            {
                grade = 4;
                Console.WriteLine(grade);
            }
            else if (point == 10 || point == 12)
            {
                grade = 5;
                Console.WriteLine(grade);
            }
        }
    }
}
