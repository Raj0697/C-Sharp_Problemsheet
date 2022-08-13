using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class bubblesort
    {
        static void Main(String[] args)
        {
            int i, j, swap, n;
            Console.WriteLine("=========BUBBLE SORT==========");
            Console.WriteLine();
            Console.WriteLine("Enter the limits : ");



            n = int.Parse(Console.ReadLine());

            //array declaration
            int[] ar = new int[n];

            Console.WriteLine("Enter " + n + " integers to proceed : ");
            for(i=0; i<n; i++)
            
                ar[i] = int.Parse(Console.ReadLine());
            

            for(i=0; i<n-1; i++)
            {
                for(j=0; j<n-i-1; j++)
                {
                    if(ar[j] > ar[j+1])
                    {
                        swap = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = swap;
                    }
                }
            }
            Console.WriteLine("The sorted list is : ");
            for(i=0; i<n; i++)
            
                Console.WriteLine(ar[i]);
            
            
            Console.ReadKey();
        }
    }
}
