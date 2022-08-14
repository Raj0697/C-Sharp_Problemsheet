using System;
using System.Collections.Generic;                                                                   // DATE : 04/12/2019
using System.Linq;                                                                                  // TIME : 08:50 AM
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class jagged_array2
    {
        public static void Main(String[] args)
        {
            char[][] at = new char[4][];
            at[0] = new char[] { 'A' };
            at[1] = new char[] { 'A', 'B' };
            at[2] = new char[] { 'A', 'B', 'C' };
            at[3] = new char[] {'A','B','C','D'};

            for(int i=0; i<at.Length; i++)
            {
                for (int j = 0; j < at[i].Length; j++)
                {
                    Console.Write(at[i][j] );
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
