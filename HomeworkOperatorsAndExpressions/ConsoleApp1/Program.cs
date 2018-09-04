using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            Console.Write("Input using Read() - ");
            userInput = Console.Read();

            bool even = userInput % 2 == 0 ? true : false;
            Console.WriteLine("{0} is even? {1}", userInput, even);
        }
    }
}
