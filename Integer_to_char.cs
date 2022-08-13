using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class Integer_to_char
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the limit : ");
            int limit = int.Parse(Console.ReadLine());
            int[] a = new int[limit];

            Console.WriteLine("Enter the integer : ");
            for (int i = 0; i < limit; i++)
                a[i] = int.Parse(Console.ReadLine());
            for(int i = 0; i<a.Length; i++)
            {
                switch(a[i])
                {
                    case 0:
                        Console.WriteLine("ZERO");
                        break;
                    case 1:
                        Console.WriteLine("ONE");
                        break;
                    case 2:
                        Console.WriteLine("TWO");
                        break;
                    case 3:
                        Console.WriteLine("THREE");
                        break;
                    case 4:
                        Console.WriteLine("FOUR");
                        break;
                    case 5:
                        Console.WriteLine("FIVE");
                        break;
                    case 6:
                        Console.WriteLine("SIX");
                        break;
                    case 7:
                        Console.WriteLine("SEVEN");
                        break;
                    case 8:
                        Console.WriteLine("EIGHT");
                        break;
                    case 9:
                        Console.WriteLine("NINE");
                        break;
                }
            }
            Console.WriteLine("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            int rem = n % 10;
            int quot = n / 10;
            int temp = rem + quot;
            for(int i=0; i<n; i++)
            {
                switch (n)
                {
                    case 0:
                        Console.Write("ZERO");
                        break;
                    case 1:
                        Console.Write("ONE");
                        break;
                    case 2:
                        Console.Write("TWO");
                        break;
                    case 3:
                        Console.Write("THREE");
                        break;
                    case 4:
                        Console.Write("FOUR");
                        break;
                    case 5:
                        Console.Write("FIVE");
                        break;
                    case 6:
                        Console.Write("SIX");
                        break;
                    case 7:
                        Console.Write("SEVEN");
                        break;
                    case 8:
                        Console.Write("EIGHT");
                        break;
                    case 9:
                        Console.Write("NINE");
                        break;
                }
            }
            

            Console.ReadKey();
        }
    }
}
