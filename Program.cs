using System;
using System.Collections.Generic;                                                           // DATE : 04/12/2019
using System.Linq;                                                                          // TIME : 08:40 AM
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[][] jag = new int[3][];
            jag[0] = new int[1] { 1 };
            jag[1] = new int[3] { 1, 2, 3 };
            jag[2] = new int[4] { 1, 2, 3, 4 };

            for(int s=0; s<jag.Length; s++)
            {
                for(int t=0; t<jag[s].Length; t++)
                {
                    Console.Write(jag[s][t]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
