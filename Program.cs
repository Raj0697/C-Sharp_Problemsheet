using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSheet_2
{
   public class Bank
    {
       public String Branch_name, IFSC_code;

       public Bank(String bname,String ifsc)
        {
            this.Branch_name = bname;
            this.IFSC_code = ifsc;
        }
    }
    public class Customer:Bank
    {
       public String name,bn,ifsccode;
       public int Acc_no, Aadhar_no, Total_Bal,bal,amt;
       public int flag = 0,temp2=0;

        public Customer(string bname, string ifsc) : base(bname, ifsc)
        {
            bn = bname;
            ifsccode = ifsc;
        }
        public void bank()
        {
            Console.WriteLine(" The branch name : " + bn);
            Console.WriteLine(" The IFSC_CODE : " + ifsccode);
        }
        public void Deposit()
        {
            flag = 1;

            Console.WriteLine("Enter the  customer name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the acc_no : ");
            Acc_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Aadhar_no : ");
            Aadhar_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount to deposit : ");
            bal = int.Parse(Console.ReadLine());
            Console.WriteLine("The total balance is : " + bal);
        }
       public void Withdraw()
        {
            Console.WriteLine("Enter the acc_no : ");
            int Acc_no2 = int.Parse(Console.ReadLine());
            if(Acc_no2 != Acc_no)
            {
                Console.WriteLine("There is no account exists in this account no!!");
            }
            else
            {
                Console.WriteLine("Enter the amount to withdraw : ");

                amt = int.Parse(Console.ReadLine());
                if(amt > bal || amt==0)
                {
                    Console.WriteLine("You are not having sufficient balance to withdraw!!!");
                    Console.WriteLine("Your current balance is : " + bal);
                }
                else
                {
                    Console.WriteLine("Rs: " + amt + " is debited from your account");
                    Console.WriteLine("Your current balance is : " + (bal - amt));
                }
            }
            
        }
        public void balance()
        {
            temp2 += bal-amt;
            Console.WriteLine("Your account no is : " + Acc_no);
            Console.WriteLine("Account holder name : " + name);
            Console.WriteLine("Your total balance available is : " + temp2);
        }
    }
   public class Program
    {
        public static void Main(string[] args)
        {
            Customer cus = new Customer("HSBC_ANNANAGAR","HSBC1234");
            
            int temp = 0;
            while (temp != 3)
            {
                Console.WriteLine("\n\n=============================----------------WELCOME TO HSBC BANK PORTAL------------------==========================\n\n");
                Console.WriteLine("`````````` PLEASE SELECT YOUR OPTION ``````````````\n\n");
                Console.WriteLine("1.NEW ACCOUNT\t 2.WITHDRAW\t 3.ACCOUNT_VIEW");
                temp = int.Parse(Console.ReadLine());
                if(temp == 1)
                {
                    cus.bank();
                    cus.Deposit();
                }
                else if(temp == 2)
                {
                    cus.Withdraw();
                }
                else
                {
                    cus.balance();
                }
            }
            Console.ReadKey();
        }
    }
}
