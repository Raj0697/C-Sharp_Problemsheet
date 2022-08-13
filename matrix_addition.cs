using System;
using System.Collections.Generic;                                                           // DATE : 26.11.2019
using System.Linq;                                                                          // TIME : 10 : 50 AM
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class matrix_addition
    {
        static void Main(String[] args)
        {
            int i, j;
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] c = new int[2, 2];

            Console.WriteLine("=======MATRIX ADDITION========");

            // a matrix 

            Console.WriteLine("Enter a matrix: ");
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(0); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // b matrix 

            Console.WriteLine("Enter b matrix : ");
            for(i = 0; i < b.GetLength(0); i++)
            {
                for(j = 0; j < b.GetLength(0); j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                    
                }
            }
            
            for(i=0; i<a.GetLength(0); i++)
            {
                for (j = 0; j < b.GetLength(0); j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    Console.Write( c[i, j]+"\t");
                }
            }
            Console.ReadKey();
        }
    }
}
