using System;
using Week1.Domain;

namespace Week1.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            UI();
        }

        public static void UI()
        {
            Palindrome palin = new Palindrome();

            System.Console.WriteLine("Please enter a string to take the Palindrome Test: ");
            string UserInput = Console.ReadLine();

            Console.WriteLine("Result: {0}", palin.PalindromeFunction(UserInput));
        }
    }
}
