using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Program5

    {
        public static void Binary( )
        {
            Console.WriteLine("Please enter a binary number:");
            string binaryString = Console.ReadLine();

            // Convert binary string to decimal
            int decimalValue = 0;
            int power = 1;  // This represents 2^0 initially

            for (int i = binaryString.Length - 1; i >= 0; i--)
            {
                if (binaryString[i] == '1')
                {
                    decimalValue += power;
                }
                power *= 2;
            }

            Console.WriteLine($"The decimal value of the binary number {binaryString} is {decimalValue}");

        }
    }
}
