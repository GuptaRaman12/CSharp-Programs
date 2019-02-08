using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labeva1
{
    class Program
    {
        static void Main(string[] args)
        {
            employeelbeva emp = new employeelbeva();
            emp.getData();
            emp.calHighest();
            Console.ReadKey();
        }
    }
}
