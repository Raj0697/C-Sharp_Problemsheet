using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class Integer_reverse
    {
        public static void Main(String[] args)
        {
            int num, remainder, reverse = 0;
            Console.WriteLine("Enter the integer : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num /= 10;
            }
            Console.WriteLine("The reversed number is : " + reverse);



            Console.ReadKey();
        }
    }
}
