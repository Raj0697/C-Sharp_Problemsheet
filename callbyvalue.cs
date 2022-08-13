using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class callbyvalue
    {
        public void call(int x)
        {
            x += 10;
            Console.WriteLine("Passed value is : " + x);
        }
        public static void Main(String[] args)
        {
            int x = 50;
            Console.WriteLine("Before calling x : " + x);
            callbyvalue cv = new callbyvalue();
            cv.call(100);
            Console.WriteLine("After calling x : " + x);
            Console.ReadKey();
        }
    }
}
