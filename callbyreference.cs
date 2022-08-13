using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class callbyreference
    {
        public void call(ref int a)
        {
            a += 90;
            Console.WriteLine("Passed value is : " + a);
        }
        public static void Main(String[] args)
        {
            int a = 50;
            Console.WriteLine("Before calling a : " + a);
            callbyreference cr = new callbyreference();
            cr.call(ref a);
            Console.WriteLine("After calling a : " + a);
            Console.ReadKey();
        }
    }
}
