using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    class bank
    {
        protected int id = 555;

        public void print()
        {
           Console.WriteLine(id);
        }
    }
    class sb:bank
    {
        public int b;
        public void printt()
        {
            Console.WriteLine(id);
            Console.WriteLine(b);
        }
    }
   
    class Program
    {
        public static void Main(string[] args)
        {
            sb s = new sb();
            s.printt();
            Console.ReadKey();
        }
    }
}
