using System;
using System.Collections.Generic;                                                                           // DATE : 04/12/2019
using System.Linq;                                                                                          // TIME : 09:00 AM
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Pyramid_using_jagged_array
    {
        public static void Main(String[] args)
        {
            char[][] p = new char[5][];

            /* using space
            p[0] = new char[] { ' ',' ',' ','A' };
            p[1] = new char[] { ' ', ' ', 'A', 'A', 'A' };
            p[2] = new char[] { ' ', 'A', 'A', 'A', 'A', 'A' };
            p[3] = new char[] { 'A', 'A', 'A', 'A', 'A', 'A', 'A' };

            for(int i=0; i<p.Length; i++)
            {
                for(int j=0; j<p[i].Length; j++)
                {
                    Console.Write(p[i][j]);
                }
                Console.WriteLine();
            }
            */
            //using forloop to print pyramid

            p[0] = new char[] { 'A' };
            p[1] = new char[] { 'A', 'A', 'A' };
            p[2] = new char[] { 'A', 'A', 'A', 'A', 'A' };
            p[3] = new char[] { 'A', 'A', 'A', 'A', 'A', 'A', 'A' };
            for(int i=0; i<p.Length; i++)
            {
                for(int j=i; j<p.Length; j++)
                {
                    Console.Write(" ");
                }
                for(int j=0; j<p[i].Length; j++)
                {
                    Console.Write(p[i][j]);
                }
                Console.WriteLine();
            }
           

            Console.ReadKey();
        }
    }
}
