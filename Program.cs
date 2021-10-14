using System;
using System.IO;
namespace myConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}");
            Console.WriteLine("Are you having a good day? Enter Y/N");

            string input = Console.ReadKey().Key.ToString();
            char response = Convert.ToChar(input);


            if (response == 'Y')
            {
                Console.WriteLine($"Good shit {userName}");
            }
            if (response == 'N')
            {
                Console.WriteLine("Ah balls");
            }
        }
    }
}