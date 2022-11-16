using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            string number = Console.ReadLine();
            int numberParsed = Int16.Parse(number);

            if (numberParsed < 1)
            {
                Console.WriteLine("number");
            }
            else if (numberParsed >= 1 && numberParsed <= 50)
            {
                Console.WriteLine("Suurem kui 1, väiksem kui 50");
            }
            else if (numberParsed > 50 && numberParsed < 99)
            {
                Console.WriteLine("Suurem kui 50, väiksem kui 99");
            }
            else
            { 
                Console.WriteLine("ERROR");
            }

        }
    }
}
