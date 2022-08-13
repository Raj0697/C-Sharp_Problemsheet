using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class Temperature_conversion
    {
        public static void Main(String[] args)
        {
            double celcius, fahrenheit, temp1, temp2;
            Console.WriteLine("=============TEMPERATURE CONVERSION===============");
            Console.WriteLine();

            Console.WriteLine("Celcius to Farenheit ");

            Console.WriteLine("Enter the celcius to calculate the fahrenheit : ");
            celcius = double.Parse(Console.ReadLine());

            Console.WriteLine();
            temp1 = (celcius * 9 / 5) + 32;

            Console.WriteLine(celcius + " degree celcius is equal to " + temp1 + " degree of fahrenheit");
            Console.WriteLine();

            Console.WriteLine("Fahrenheit to Celcius");

            Console.WriteLine("Enter the fahrenheit to calculate the celcius : ");
            fahrenheit = double.Parse(Console.ReadLine());

            Console.WriteLine();
            temp2 = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine(fahrenheit + " degree fahrenheit is equal to " + temp2 + " degree of celcius");

            float f = 0.1f;
            Console.WriteLine(f);

            Console.ReadKey();
        }
    }
}
