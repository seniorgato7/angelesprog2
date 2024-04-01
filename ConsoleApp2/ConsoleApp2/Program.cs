using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 100; num++)
            {
                if (num % 15 == 0) // Check for divisibility by both 3 and 5 first
                {
                    Console.WriteLine("Hello Goodbye");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Hello");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}