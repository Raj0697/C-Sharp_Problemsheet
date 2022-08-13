using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class Sum_of_digits
    {
        public static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Enter the number : ");
            num = int.Parse(Console.ReadLine());
            int remainder = num % 10;
            int quotient = num / 10;
            int temp = remainder + quotient;

            Console.WriteLine("Sum of the digits of " + num + " : " + temp);
            Console.ReadKey();
        }
    }
}
