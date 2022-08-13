using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class Prime_Number
    {
        public static void Main(String[] args)
        {
            int flag = 0, n, i,start,end;
            Console.WriteLine("Enter the number : ");
            n = int.Parse(Console.ReadLine());
            //prime number condition
            for(i=2; i<=n/2; i++)
            {
                if(n%i==0)
                {
                    flag = 1;
                    break;
                }
            }
            if(n==1)
            {
                Console.WriteLine("1 is neither prime nor composite");
            }
            else
            {
                if (flag == 0)
                {
                    Console.WriteLine(n + " is a prime number");
                }
                else
                {
                    Console.WriteLine(n + " is not a prime number");
                }
            }
            
            
            Console.ReadKey();
        }
    }
}
