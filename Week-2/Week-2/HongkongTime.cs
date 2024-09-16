using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class HongkongTime:localTime
    {
        public override void DisplayTimeAndCity()
        {
            DateTime hongKongTime = GetUTCTime().AddHours(8); // Hong Kong is UTC+8
            Console.WriteLine($"Hong Kong Time: {hongKongTime:HH:mm:ss}");
        }
    }
}
