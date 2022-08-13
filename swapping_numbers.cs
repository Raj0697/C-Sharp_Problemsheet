using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class swapping_numbers
    {
        public static void Main(String[] args)
        {
            int a,b,temp;
            Console.WriteLine("Enter the first number : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            b = int.Parse(Console.ReadLine());
            temp = b;
            int swap = a;
            //a = b;
           // b = temp;
            Console.WriteLine("now first number is : " + temp);
            Console.WriteLine("now second number is : " + swap);
            Console.ReadKey();
        }
    }
}
