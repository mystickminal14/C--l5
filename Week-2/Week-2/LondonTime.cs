using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class LondonTime : localTime

    {
        public override void DisplayTimeAndCity()
        {
            DateTime londonTime = GetUTCTime(); // London is UTC+0
            Console.WriteLine($"London Time: {londonTime:HH:mm:ss}");
        }
    }
   
}
