//this is my first app
using System;
using System.Collections;
namespace ConsoleApp1
{
    class Add2Numbers
    {
        static void Main(string[] args)
        {
            int intNum1;
            int intNum2;
            int result;
            Console.WriteLine("Enter the first number");
            intNum1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            intNum2=Convert.ToInt16(Console.ReadLine());
            result = intNum1 + intNum2;
            Console.WriteLine("Sum of"+ intNum1 +" and "+ intNum2 +" is "+ result);
            Console.ReadLine();
            //Class1 obj = new Class1();
            
        }
    }
}
