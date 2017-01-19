using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("How old are you? ");
            string line = Console.ReadLine();
            age = int.Parse(line);

            if(age <= 17)
            {
                Console.WriteLine("Underage");
            }
            else if (age >=18 && age <= 65)
            {
                Console.WriteLine("Adult");
            }
            else if (age >65)
            {
                Console.WriteLine("Senior");
            }
        }
    }
}
