using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01b
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask Number
            int number;
            Console.Write("Give a number > ");
            string line = Console.ReadLine();   //kokonaisluku
            bool result = int.TryParse(line, out number);   //kokonaisluku -> numero
            if (result == true)
            {
            //Which number..
            switch (number)
            {
                case 1:
                    Console.WriteLine("yksi");
                    break;
                case 2:
                    Console.WriteLine("kaksi");
                    break;
                case 3:
                    Console.WriteLine("kolme");
                    break;
                default:
                    Console.WriteLine("joku muu lause");
                    break;
            }
        } else
        {
            Console.WriteLine("Not a integer valua!");
        }
      }
    }
}
