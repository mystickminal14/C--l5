using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassWork
{
    internal class Program3
    {
        //WAP that creates a method that calculates the factorial of a given number.Handle the OverflowException that occurs if the result exceeds the Int32 maximum value.
        public static void Factorial(int number)
        {
            try
            {
                int pro = 1;

                // Calculate the factorial
                for (int i = 1; i <= number; i++)
                {
                    pro = checked(pro * i);  // 'checked' detects overflow
                }

                // Print the final result
                Console.WriteLine($"Factorial of {number} is {pro}");
            }
            catch (OverflowException)
            {
                // Handle overflow exception
                Console.WriteLine("The result exceeds the maximum limit of an Int32 value.");
            }
        }
    }
}
