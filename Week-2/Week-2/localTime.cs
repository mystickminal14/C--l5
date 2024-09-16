using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class localTime
    {
        public virtual void DisplayTimeAndCity()
        {
            Console.WriteLine("This is the base class method.");
        }

        // Method to get the current time in UTC
        protected DateTime GetUTCTime()
        {
            return DateTime.UtcNow;
        }
    }
}
