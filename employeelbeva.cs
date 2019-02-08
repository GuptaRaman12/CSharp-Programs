using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labeva1
{
    class employeelbeva
    {
        public string emp_name1,emp_name2,emp_name3;
        public string emp_id1,emp_id2,emp_id3;
        public double emp_sal1, emp_sal2, emp_sal3;
        public void getData()
        {
            // Data of Employee 1
            Console.WriteLine("Enter the name of employee1:");
            emp_name1=Console.ReadLine();
            Console.WriteLine("Enter the id of employee1:");
            emp_id1 =Console.ReadLine();
            Console.WriteLine("Enter the salary of employee1:");
            emp_sal1 =double.Parse(Console.ReadLine());
            // Data of Employee 2
            Console.WriteLine("Enter the name of employee2:");
            emp_name2 = Console.ReadLine();
            Console.WriteLine("Enter the id of employee2:");
            emp_id2 = Console.ReadLine();
            Console.WriteLine("Enter the salary of employee2:");
            emp_sal2 = double.Parse(Console.ReadLine());
            // Data of Employee 3
            Console.WriteLine("Enter the name of employee3:");
            emp_name3 = Console.ReadLine();
            Console.WriteLine("Enter the id of employee3:");
            emp_id3 = Console.ReadLine();
            Console.WriteLine("Enter the salary of employee3:");
            emp_sal3 = double.Parse(Console.ReadLine());
        }
        public void calHighest()
        {
            Console.WriteLine("The Details of the Employee who got Highest Salary is Displayed Below:");
            if ((emp_sal1>emp_sal2)&&(emp_sal1>emp_sal3))
            {
                dispData1();
            }
            else if ((emp_sal2 > emp_sal1) && (emp_sal2 > emp_sal3))
            {
                dispData2();
            }
            else
            {
                dispData3();
            }
        }
        public void dispData1()
        {
            Console.WriteLine("Employee Name :"+emp_name1);
            Console.WriteLine("Employee Id :" + emp_id1);
            Console.WriteLine("Employee Salary :" + emp_sal1);
        }
        public void dispData2()
        {
            Console.WriteLine("Employee Name :" + emp_name2);
            Console.WriteLine("Employee Id :" + emp_id2);
            Console.WriteLine("Employee Salary :" + emp_sal2);
        }
        public void dispData3()
        {
            Console.WriteLine("Employee Name :" + emp_name3);
            Console.WriteLine("Employee Id :" + emp_id3);
            Console.WriteLine("Employee Salary :" + emp_sal3);
        }
    }
}
