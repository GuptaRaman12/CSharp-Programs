using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCSharpprgs
{
    class Student
    {
        private string studentName;
        private string studentId;
        public string StudentName
        {
            get => studentName;
            set => studentName = value;
        }
        public string StudentId
        {
            get => studentId;
            set => studentId = value;
        }
    }
}
