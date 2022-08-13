using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class Palindrome
    {
        public static void Main(String[] args)
        {
            int num,remainder,reverse=0;
            String str,rev="";
            //Console.WriteLine("Enter the number : ");
            //num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the string : ");
            str = Console.ReadLine();
            int length = str.Length - 1;
            while(length >= 0)
            {
                rev += str[length];
                length--;
            }
            Console.WriteLine("The reversed string is : " + rev);
            if(rev == str)
            {
                Console.WriteLine("PALINDROME STRING");
            }
            else
            {
                Console.WriteLine("Not a palindrome string");
            }
            Console.WriteLine("Enter the integer : ");
            num = int.Parse(Console.ReadLine());
            int temp = num;
            while (num != 0)
            {
                remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num /= 10;
            }
            Console.WriteLine("The reversed number is : " + reverse);
            if(reverse == temp)
            {
                Console.WriteLine("Palindrome number");
            }
            else
            {
                Console.WriteLine("Not a palindrome number");
            }
            Console.ReadKey();
        }
    }
}
