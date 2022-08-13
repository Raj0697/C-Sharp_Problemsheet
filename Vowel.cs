using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class Vowel
    {
        public static void Main(String[] args)
        {
            int vowel_count = 0, cons_count = 0;
            String str,strcount="";
            Console.WriteLine("Enter the string : ");
            str = Console.ReadLine();
            str = str.ToLower();
            // char s = char.Parse(str.Substring(0, 1));
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowel_count++;
                    strcount += str[i];
                }
                else
                {
                    cons_count++;
                }
            }
            Console.WriteLine("Total vowel is : " + vowel_count);
            Console.WriteLine("Total consonant is : " + cons_count);
            Console.WriteLine("The vowels are : " + strcount);
            Console.ReadKey();

            }
        }
    }
