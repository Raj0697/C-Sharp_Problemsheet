using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    public class Employee
    {
        public String name;
        public int age;

        public Employee(int age)
        {
            name = "kumar";
            this.age = age;
        }
        public Employee(String name,int age)
        {
            this.name = name;
            this.age = age;
        }
        //copy constructor
        public Employee(Employee e)
        {
            name = e.name;
            age = e.age;
        }

        public void print()
        {
            Console.WriteLine("the name is :" + name);
            Console.WriteLine("the age is : " + age);
        }
    }
    class Copy_constructor
    {
        public static void Main(String[] args)
        {
            Employee e = new Employee(23);
            Employee e1 = new Employee("raj", 23);
            //creating the object for copy constructor
            Employee e2 = new Employee(e1);
            e.print();
            e2.print();
            Console.ReadKey();
        }
    }
}
