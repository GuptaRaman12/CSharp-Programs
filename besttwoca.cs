using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCSharpprgs
{
    class besttwoca
    {
        public string name;
        public string reg;
        public string course;
        public int ca1,ca2,ca3;
        public int best1,best2,low;
        public void getDetails()
        {
            Console.WriteLine("Enter the Name of Student :");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Registration Number of Student :");
            reg = Console.ReadLine();
            Console.WriteLine("Enter the Course Code of Student :");
            course = Console.ReadLine();
            Console.WriteLine("Enter the marks of CA1 :");
            ca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks of CA2 :");
            ca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks of CA3 :");
            ca3 = int.Parse(Console.ReadLine());
        }
        public void best1Cal()
        {
            if ((ca1 > ca2) && (ca1 > ca3))
                best1 = ca1;
            else if ((ca2 > ca1) && (ca2 > ca3))
                best1 = ca2;
            else
                best1 = ca3;
            Console.WriteLine("")
        }
        public void lowest()
        { 
            if ((ca1 < ca2) && (ca1 < ca3))
                low = ca1;
            else if ((ca2 < ca1) && (ca2 < ca3))
                low = ca2;
            else
                low = ca3;
            best2 = (ca1 + ca2 + ca3) - (best1 + low);
        }
    }
}
