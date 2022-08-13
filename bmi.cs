using System;
using System.Collections.Generic;
using System.Linq;                                                                              // DATE : 26.11.2019
using System.Text;
using System.Threading.Tasks;
                                                                                
namespace maximum
{                                                                                                   
    class weight
    {
        static void Main(string[] args)
        {
            int age;
            double ht, wt, bmi; ;
            String gen,name;

            Console.WriteLine("==========calculate normal weight===============");
            Console.WriteLine();
            Console.WriteLine("	Calculate the normal weight for both male and female with age limit 25 to 55");

            Console.WriteLine("Enter the name of the person : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter the age of " + name + " : ");
            age =int.Parse(Console.ReadLine());

           
            Console.WriteLine("Enter the gender : ");
            gen = Console.ReadLine();

            Console.WriteLine("Enter the height in m : ");
            ht = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the weight in kg : ");
            wt = double.Parse(Console.ReadLine());

            Console.WriteLine("The formula to find BMI is : weight(kg) / height(m^)");
            Console.WriteLine();

            if(age >= 25 && age <= 55 )
            {
                bmi = wt / (ht * ht);
                Console.WriteLine("The BMI for " + name + " is :" + bmi);
            }
            else
            {
                Console.WriteLine("Enter age between 25 and 55" );
            }
            Console.ReadKey();
        }
    }
}
