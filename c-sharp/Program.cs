using System;

namespace csharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Would you like to multiply numbers? Y/N?");
            string firstInput = Console.ReadLine().ToUpper();
            if (firstInput == "Y")
            {
                Console.WriteLine("I will multiply a number by 5! What's your number?");
                string secondInput = Console.ReadLine();
                int x;
                if (int.TryParse(secondInput, out x))
                {
                    Console.WriteLine(x * 5);
                }
                else
                {
                    Console.Beep();
                    Console.WriteLine("Whoa there... " + secondInput + " is not a number!");
                }
            }
            else
            {
                Console.WriteLine("Ok, here's some handy info:");
                Console.WriteLine("A byte's minimum and maximum values are {0} and {1} respectively.", byte.MinValue, byte.MaxValue);
                Console.WriteLine("A float's minimum and maximum values are {0} and {1} respectively.", float.MinValue, float.MaxValue);
            }
        }
    }
}
