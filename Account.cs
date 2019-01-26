using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCSharpprgs
{
    class Account
    {
        public double bal;
        public string acc;
        public double amt;
        public string ch;
        public char op;
        public Account()
        {
            bal = 5000;
        }
        public void details()
        {
            Console.WriteLine("Enter the valid Account Number");
            acc = Console.ReadLine();
        }
        public void withdrawal()
        {
             /*if(bal>10000)
            {
               bal -= amt;
                Console.WriteLine("Transaction Sucessfully Completed!");
            }*/
            if ((bal - amt) <= 5000)
            {
                
                    Console.WriteLine("You cannot Widthdrawal! Transaction Failed.");
            }
            else
            {
                bal -= amt;
                Console.WriteLine("Transaction Sucessfully Completed!");
            }
            balance();
        }
        public void deposit()
        {
            bal += amt;
            balance();
        }
        public void balance()
        {
            Console.WriteLine("Your Account Number is : " + acc);
            Console.WriteLine("Your Total Balance is : " + bal);
        }
        public void select()
        {
            Console.WriteLine("Eneter 1. to Widthdrawal Amount:");
            Console.WriteLine("Eneter 2. to Deposit Amount:");
            Console.WriteLine("Eneter 3. to Check Balance Amount:");
            Console.WriteLine("Eneter 4. to Exit");
            Console.WriteLine("Eneter your choice:");
            ch = Console.ReadLine();
            switch(ch)
            {
                case "1":
                    Console.WriteLine("Enter the Amount you want to widthdrawal");
                    amt = double.Parse(Console.ReadLine());
                    withdrawal();
                    Console.WriteLine("Do you want to continue Press Y/y to Continue or n/N to exit:");
                    op = char.Parse(Console.ReadLine());
                    if ((op == 'y') || (op == 'Y'))
                    {
                        select();
                        Console.ReadLine();
                    }
                    break;
                case "2":
                    Console.WriteLine("Enter the Amount you want to deposit");
                    amt = double.Parse(Console.ReadLine());
                    deposit();
                    Console.WriteLine("Do you want to continue Press Y/y to Continue or n/N to exit:");
                    op = char.Parse(Console.ReadLine());
                    if ((op == 'y') || (op == 'Y'))
                    {
                        select();
                        Console.ReadLine();
                    }
                    break;
                case "3":
                    balance();
                    Console.WriteLine("Do you want to continue Press Y/y to Continue or n/N to exit:");
                    op = char.Parse(Console.ReadLine());
                    if ((op == 'y') || (op == 'Y'))
                    {
                        select();
                        Console.ReadLine();
                    }
                    break;
                case "4":
                    break;
            }
        }
    }
}
