using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class factorial
    {
        static void Main(String[] args)
        {
            Console.WriteLine("========================FACTORIAL=========================");
            int fact = 1, n, i;
            Console.WriteLine("Enter any number : ");
            n = int.Parse(Console.ReadLine());
            for(i=1; i<=n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of "+ n + " is :"+fact);

            Console.ReadKey();
        }
    }
}
