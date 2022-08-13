using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class Prime_number_between_ranges
    {
        public static void Main(String[] args)
        {
            int start, end, i;
            int f = 0;
            Console.WriteLine("Enter the starting number : ");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ending number : ");
            end = int.Parse(Console.ReadLine());

            while(start > end)
            {
                
                for (i=2; i<=start/2; i++)
                {
                    if(start % i == 0)
                    {
                        f = 1;
                        break;
                    }
                }
                // if f==0 then it is prime number, so we are incrementing the start value using while loop
                if(f==0)
                {
                    Console.Write("" + start);
                    ++start;
                }
               
            }
            
            Console.ReadKey();
        }
    }
}
