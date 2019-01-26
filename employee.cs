using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCSharpprgs
{
    class employee
    {
       public int empId;
       public string empName;
       public double net_empSal,tax,gross_empSal;
       public float allowance;
       public employee()
       {
            allowance = 1000;
       }
       public void getDetail()
       {
            Console.WriteLine("Enter the Employee ID");
            empId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name");
            empName =Console.ReadLine();
            Console.WriteLine("Enter the Employee Gross Salary");
            gross_empSal = double.Parse(Console.ReadLine());
            
        }
        public void Cal()
        {
            tax = gross_empSal * 0.10;
            net_empSal = (gross_empSal + allowance) - tax;
        }
        public void Display()
        {
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine("Employee Gross Salary: " + gross_empSal);
            Console.WriteLine("Tax Paid  : " + tax);
            Console.WriteLine("Employee Net Salary: " + net_empSal);
            
        }

    }
}
