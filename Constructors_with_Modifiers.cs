using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    class vehicle
    {
        String name;
        int engine_no;
        String petrol_type;

        public vehicle()
        {
            Console.WriteLine("=====vehicle information=========");
        }
        
        protected vehicle(String name,int eno)
        {
            this.name = name;
            this.engine_no = eno;
        }

        private vehicle(int eng_no)
        {
            this.engine_no = eng_no;
        }

        protected vehicle(String petrol_type)
        {
            this.petrol_type = petrol_type;
        }

        
    }
    class car:vehicle
    {
        int t = 0;
        public void dis()
        {
            Console.WriteLine(t);
        }
    }
    class Constructors_with_Modifiers
    {
        public static void Main(String[] args)
        {
            car c = new car();
            c.dis();
            Console.ReadKey();
        }
    }
}
