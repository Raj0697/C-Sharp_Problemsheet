using System;
using System.Collections.Generic;                                                                   // DATE : 26.11.2019
using System.Linq;                                                                                  // TIME : 10:20 AM
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class meter_conversion
    {
        static void Main(String[] args)
        {
            double km , m, cm, dm, mm, feet, meter;
            Console.WriteLine("=================METER CONVERSION==================");
            Console.WriteLine();
      
            Console.WriteLine("The formula is 1km = 1000 m ");
            Console.WriteLine("The formula is 1km = 10000 dm ");
            Console.WriteLine("The formula is 1km = 100000 cm ");
            Console.WriteLine("The formula is 1km = 1000000 mm ");

            Console.WriteLine("Enter the km to convert : ");

            //metre
            km = double.Parse(Console.ReadLine());
            m = km * 1000;

            //desimetre
            dm = km * 10000;

            //centimetre
            cm = km * 100000;

            //millemetre
            mm = km * 1000000;

            Console.WriteLine(km + " km is equal to " + m + " m ");
            Console.WriteLine();

            Console.WriteLine(km + " km is equal to " + dm + " dm ");
            Console.WriteLine();

            Console.WriteLine(km + " km is equal to " + cm + " cm ");
            Console.WriteLine();

            Console.WriteLine(km + " km is equal to " + mm + " mm ");
            Console.WriteLine();

            Console.WriteLine("metre to feet ");
            Console.WriteLine();
            Console.WriteLine("formula is 1m = 3.281 feet [3 feet 3.37 inches ");
            Console.WriteLine("Enter the meter to convert to feet : ");
            meter = double.Parse(Console.ReadLine());

            feet = meter * 3.281;
            Console.WriteLine(meter + " meter is equal to " + feet + " feet ");
            Console.WriteLine();
            Console.WriteLine("========================THE END=======================");
            Console.ReadKey();
        }
    }
}
