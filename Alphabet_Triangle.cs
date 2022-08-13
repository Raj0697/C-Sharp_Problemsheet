using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    public class Alphabet_Triangle
    {
        public static void Main(String[] args)
        {
            char[][] a = new char[5][];
            a[0] = new char[] {'A'};
            a[1] = new char[] {'A','B','A'};
            a[2] = new char[] {'A','B','C','B','A'};
            a[3] = new char[] {'A','B','C','D','C','B','A'};
            a[4] = new char[] {'A','B','C','D','E','D','C','B','A'};

            for(int i=0; i<a.Length; i++)
            {
                for(int j=i; j<a.Length; j++)
                {
                    Console.Write(" ");
                }
                for(int j=0; j<a[i].Length; j++)
                {
                    Console.Write(a[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
