using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCSharpprgs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*employee em = new employee();
            em.getDetail();
            em.Cal();
            em.Display();
            employee2 em = new employee2();
            em.getDetail();
            em.Select();*/
            Account ac = new Account();
            ac.details();
            ac.select();


        }
    }
}
