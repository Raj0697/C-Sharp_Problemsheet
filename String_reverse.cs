using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class String_reverse
    {
        public static void Main(String[] args)
        {
            String str, rev = "";
            Console.WriteLine("Enter the string : ");
            str = Console.ReadLine();
            //   char[] c = str.ToArray();
            //   Array.Reverse(c);
            //   Console.WriteLine(c);
            int len = str.Length - 1;
            while(len >= 0)
            {
                rev += str[len];
                len--;
            }
            Console.WriteLine("The reversed string is : " + rev);
            Console.ReadKey();
        }
    }
}
