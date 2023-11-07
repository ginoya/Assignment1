using Assignment1;
using System;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            int length = LengthHelper.findLength(input);

            Console.WriteLine($"The length of the string is: {length}");
        }
    }
}