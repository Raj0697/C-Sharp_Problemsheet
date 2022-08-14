using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    class A
    {
        protected int x=10;
        public void print()
        {
            Console.WriteLine(x);
        }
    }
    class B:A
    {
        protected int y=90;
        public void show()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
    class C:B
    {
        private int z = 88;
        public void pr()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
    class Inheritance_modifiers
    {
        public static void Main(String[] args)
        {
            C obj = new C();
            obj.pr();
            Console.ReadKey();
        }
    }
}
