using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var num = Console.ReadLine();
            Console.WriteLine(num.Split(' '));
        }

        public static void CheckPalindrome(int value)
        {
            int originalValue = value;
            int reverse = 0;
            int remainder;

            while (value != 0)
            {
                remainder = value % 10;
                reverse = (reverse * 10) + remainder;
                value = value / 10;
            }

            if (originalValue == reverse)
            {
                Console.WriteLine($"{originalValue} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{originalValue} is not a palindrome.");
            }
        }
    }
}
