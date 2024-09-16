using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassWork
{
    internal class Program2
    {
        // Method to calculate the angle between the hour and minute hands of a clock
        public static void Degree(int hr, int min)
        {
            if (min == 60)
            {
                min = 0;
                hr += 1;
                if (hr > 12)
                {
                    hr = hr - 12;
                }
            }

            // Calculate the angles
            int hour_angle = (int)(0.5 * (hr * 60 + min));  // Hour hand moves 0.5 degrees per minute
            int minute_angle = (int)(6 * min);              // Minute hand moves 6 degrees per minute

            // Find the difference between the two angles
            int angle = Math.Abs(hour_angle - minute_angle);

            // Find the smaller angle (either clockwise or counterclockwise)
            angle = Math.Min(360 - angle, angle);

            // Output the result
            Console.WriteLine($"The angle between the hour and minute hands is: {angle} degrees.");
        }
    }
}


