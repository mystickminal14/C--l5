using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class Fibonacci
    {
        public static void fibo( int n) {
            int f1 = 1;
            int f2 = 1;
            int fibo = 0;

            Console.WriteLine(f1);
            if (n > 1)
            {
                Console.WriteLine(f2);
            }

            for (int i = 3; i <= n; i++)
            {
                fibo = f1 + f2;
                Console.WriteLine(fibo);
                f1 = f2;
                f2 = fibo;
            }



        }
    }
}
