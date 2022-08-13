using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class Fibonacci_series
    {
        public static void Main(String[] args)
        {
            int n, t1 = 0, t2 = 1, sum;
            Console.WriteLine("Enter the no.of count : ");
            n = int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                Console.Write(" " + t1);
                sum = t1 + t2;
                t1 = t2;
                t2 = sum;
            }

            Console.ReadKey();
        }
    }
}
