using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class TokyoTime: localTime
    {
        public override void DisplayTimeAndCity()
        {
            DateTime tokyoTime = GetUTCTime().AddHours(9); // Tokyo is UTC+9
            Console.WriteLine($"Tokyo Time: {tokyoTime:HH:mm:ss}");
        }
    }
}
