using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSheet_2
{
    public struct personal
    {
        public String name;
        public int age, weight;

        public personal(String name,int age,int weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }
        public void print()
        {
            Console.WriteLine("\n\n                                                    WELCOME TO STRUCTS                     \n\n");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\tMy name is : " + name);
            Console.WriteLine("\tMy age is : " + age);
            Console.WriteLine("\tMy weight is : " + weight +"\n");
        }
    }
   public class Struct
    {
        public static void Main(String[] args)
        {
            personal p = new personal("Raj",22,58);
            personal p2 = new personal("Swetha", 22, 55);
            p.print();
            p2.print();
            Console.ReadKey();
        }
    }
}
