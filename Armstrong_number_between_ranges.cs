using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class Armstrong_number_between_ranges
    {
        public static void Main(String[] args)
        {
            int start, end, temp, sum, remainder;
            Console.WriteLine("Enter the starting number : ");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ending number : ");
            end = Convert.ToInt32(Console.ReadLine());

            for(int i=start; i<=end; i++)
            {
                temp = i;
                sum = 0;
                while(temp > 0)
                {
                    remainder = temp % 10;
                    temp /= 10;
                    sum += remainder * remainder * remainder;
                }
                if(sum == i)
                {
                    Console.Write(" {0} " , i );
                }
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
