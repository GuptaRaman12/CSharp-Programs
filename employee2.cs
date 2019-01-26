using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCSharpprgs
{
    class employee2
    {
        public int empId;
        public string empName;
        public double net_empSal, tax,gross_empSal;
        public float allowance;
        public int days;
        public char ch;
        public string userId;
        public string passCode;
        char op;
        public employee2()
        {
            allowance = 1000;
        }
        public void getDetail()
        {
            Console.WriteLine("Enter the Employee ID");
            empId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name");
            empName = Console.ReadLine();
            Console.WriteLine("Enter the Number of Days Employee Work");
            days = int.Parse(Console.ReadLine());

        }
        public void Cal()
        {
            gross_empSal = 250.00 * days;
            tax = gross_empSal * 0.10;
            net_empSal = (gross_empSal + allowance) - tax;
            Console.WriteLine("Employee Net Salary: " + net_empSal);
        }
        public void Display()
        {
            Cal();
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine("Employee Gross Salary: " + gross_empSal);
            Console.WriteLine("Tax Paid  : " + tax);
        }
        public void Select()
        {
            Console.WriteLine("Enter the :");

            Console.WriteLine("Enter 1 to see employee details:");
            Console.WriteLine("Enter 2 to Calculate Net Salary:");
            Console.WriteLine("Enter 3 to Calculate Gross Salary :");
            Console.WriteLine("Enter 4 to Exit:");
            Console.WriteLine("Enter the Choice:");
            ch =char.Parse(Console.ReadLine());
            switch(ch)
            {
                case '1':
                    Display();
                    Console.WriteLine("Do you want to continue Press Y/y to Continue or n/N to exit:");
                    op=char.Parse(Console.ReadLine());
                    if ((op == 'y') || (op == 'Y'))
                    {
                        Select();
                        Console.ReadLine();
                    }
                    break;
                case '2':
                    Cal();
                    Console.WriteLine("Do you want to continue Press Y/y to Continue or n/N to exit:");
                    op = char.Parse(Console.ReadLine());
                    if ((op == 'y') || (op == 'Y'))
                    {
                        Select();
                        Console.ReadLine();
                    }
                    break;
                case '3':
                    gross_empSal = 250 * days;
                    Console.WriteLine("Gross Salary of employee :" + gross_empSal);
                    Console.WriteLine("Do you want to continue Press Y/y to Continue or n/N to exit:");
                    op = char.Parse(Console.ReadLine());
                    if ((op == 'y') || (op == 'Y'))
                    {
                        Select();
                        Console.ReadLine();
                    }
                    break;
                case '4':
                    System.Environment.Exit(0);
                    break;
            }

        }

    }


}

