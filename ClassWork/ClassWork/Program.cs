using System;

namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input for prime number check
            Console.WriteLine("Please enter a number to check if it's prime:");
            int number = int.Parse(Console.ReadLine());
            Prime(number); // Uncomment this if you want to check prime number functionality

            // Input for clock angles
            Console.WriteLine("Input hour (1-12):");
            int hr = int.Parse(Console.ReadLine());
            Console.WriteLine("Input minute (0-59):");
            int min = int.Parse(Console.ReadLine());

            // Validate input and find the angle between the hour and minute hands
            if (hr > 12 || min >= 60 || hr < 0 || min < 0)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Program2.Degree(hr, min);
            }

            Console.WriteLine("Input number");
            int check = int.Parse(Console.ReadLine());
            Program3.Factorial(check);
            Program4.Sqr(check);
            Program5.Binary();
        }

        // Method to check if a number is prime
        public static void Prime(int number)
        {
            bool isPrime = true;

            if (number <= 1)
            {
                Console.WriteLine($"{number} is not a prime number.");
                return;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
    }

}