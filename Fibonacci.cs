using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class Fibonacci
    {
        public static void Main(String[] args)
        {
            int t1 = 0, t2 = 1, sum = 0;
            Console.WriteLine("Enter the no.of limits ");
            int limit = int.Parse(Console.ReadLine());
            Console.Write("Fibonacci series : " + t1 + " " + t2);
            sum = t1 + t2;
            while (sum <= limit)
            {
                Console.Write(" " + sum);
                t1 = t2;
                t2 = sum;
                sum = t1 + t2;
            }
            Console.ReadKey();
        }
    }
}
