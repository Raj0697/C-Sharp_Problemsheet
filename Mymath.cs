using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    static class mymath
    {
        public static double pi = 3.14;
    }

    class Mymath
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the radius : ");
            int radius = int.Parse(Console.ReadLine());
            double area = (mymath.pi*(radius*radius));
            Console.WriteLine("Area of the circle is : " + area);
            Console.ReadKey();
        }
    }
}
