using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class NewYorkTime : localTime
    {
        public override void DisplayTimeAndCity()
        {
            DateTime newYorkTime = GetUTCTime().AddHours(-5); // New York is UTC-5
            Console.WriteLine($"New York Time: {newYorkTime:HH:mm:ss}");
        }
    }
   
}
