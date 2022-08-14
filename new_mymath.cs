using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class mymath2
    {
        public static double pi = 3.14;
    }
    class new_mymath
    {
        public static void Main(String[] args)
        {
            new_mymath nm = new new_mymath();
            Console.WriteLine("Enter the radius : ");
            double r = double.Parse(Console.ReadLine());
           double area = (mymath2.pi * (r * r));
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
