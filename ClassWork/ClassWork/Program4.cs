using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ClassWork
{
    internal class Program4

    {
        //AP that reads a number from the user and calculates its square root.Handle the exception if the number is negative.

        public static void Sqr(int num)
        {
            try
            {
                if (num < 0)
                {
                    throw new ArgumentException("Cannot compute the square root of a negative number.");
                }

                double sqrt = Math.Sqrt(num); // Calculate square root
                Console.WriteLine($"Square root of {num} is {sqrt}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); // Handle the exception
            }

        }
    }
}
