using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Account
    {
        int id;
        String name;
        static double ROI;

        public Account(int id,String name)
        {
            this.id = id;
            this.name = name;
        }
        //static constructor for ROI
        static Account()
        {
            ROI = 2.5;
        }

        public void display()
        {
            /*
            Console.WriteLine("Enter number of employees : ");
            int no = int.Parse(Console.ReadLine());
            for(int  i=0; i<no; i++)
            {
                Console.WriteLine("Enter the id : ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the name : ");
                name = Console.ReadLine();
                Console.WriteLine("The ROI for all Employees is : " + ROI);
            }*/
            Console.WriteLine("\n\n==============---------------**************EMPLOYEE DETAILS OF ZOHOO***************------------==============\n");
            Console.WriteLine("The id : " + id);
            Console.WriteLine("The name of the Employee is : " + name);
            Console.WriteLine("The ROI for all Employees is : " + ROI);
        }
    }
    class Account_static_constructor
    {
        public static void Main(String[] args)
        {
            Account a1 = new Account(23,"abc");
            Account a2 = new Account(45, "RAJ");
            a1.display();
            a2.display();
            Console.ReadKey();
        }
    }
}
