using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Multidimensional_jagged_array
    {
        public static void Main(String[] args)
        {
            int[][,] multi = new int[3][,]
            {
                new int[,]{ { 1, 1 },{ 1, 2},{ 1, 3 } },
                new int[,]{ { 2, 1 },{ 2,2},{ 2, 3 } },
                new int[,]{ { 3, 1 },{ 3, 2 },{ 3,3} }
            };

            for(int i=0; i<multi.Length; i++)
            {
                for(int j=0; j<multi[i].GetLength(0); j++)
                {
                    for(int k=0; k<multi[i].GetLength(1); k++)
                    {
                        Console.Write(" "+multi[i][j,k]);
                    }
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
