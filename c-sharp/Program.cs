using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will multiply a number by 5! What's your number?"); 
            string input = Console.ReadLine();
            int x;
            if (int.TryParse(input, out x))
            {
                Console.WriteLine(x * 5);
            }
            else
            {
                Console.Beep();
                Console.WriteLine("Wow... " + input + " is not a number!");
            }
        }
    }
}
