using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class Names_alphabetorder
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the limit : ");
            int l = int.Parse(Console.ReadLine());

            String[] s = new String[l];

            Console.WriteLine("Enter the names one by one : ");
            for(int i=0; i<l; i++)
                s[i] = Console.ReadLine();
            /*
            for (int i=0; i<s.Length; i++)
            {
                Array.Sort(s);
                Console.WriteLine("The sorted names are : " + s[i]);
            }
            */

            List<string> name = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                name.Add(s[i]);
            }
            name.Sort();
            foreach (String st in name)
                Console.WriteLine(st);
            Console.ReadKey();
        }
    }
}
