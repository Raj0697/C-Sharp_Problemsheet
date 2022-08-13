using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class Armstrong_number
    {
        public static void Main(String[] args)
        {
            int n, temp, sum = 0;
            Console.WriteLine("Enter the number : ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while(n > 0)
            {
                int remainder = n % 10;
                sum += remainder * remainder * remainder;
                n = n / 10;
            }
            if(temp == sum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not a Armstrong number");
            }
            Console.ReadKey();
        }
    }
}
