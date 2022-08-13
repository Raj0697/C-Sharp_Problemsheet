using System;
using System.Collections.Generic;                                                                           // DATE : 02/12/2019
using System.Linq;                                                                                          // TIME : 12:30 PM
using System.Text;
using System.Threading.Tasks;                                           // incomplete

namespace maximum
{
    class matrix_multiplication
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("======MATRIX MULTIPLICATION=========");
            int i, j, sum = 0, k;
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] c = new int[2, 2];
           
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
            for (i = 0; i < b.GetLength(0); i++)
            {
                for (j = 0; j < b.GetLength(0); j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());

                }
            }
            for(k=0; k < a.GetLength(0); k++)
            {

                for (i = 0; i < a.GetLength(0); i++)
                {
                    for (j = 0; j < b.GetLength(0); j++)
                    {
                        sum = sum + ((a[i, j] * b[i, k]) + (a[k, j] * b[i, j]));
                        c[i, j] = sum;
                        
                    }
                    
                }
                
            }
           // Console.WriteLine(c[i,j]);
            Console.ReadKey();

        }
    }
}
