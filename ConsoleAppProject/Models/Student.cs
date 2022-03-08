using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    public class Student
    {
        public string FullName;
        public bool IsWarranted;

        public Student()
        {

        }
        public Student(string fullName, bool isWarranted)
        {
            FullName = fullName;
            IsWarranted = isWarranted;
        }

    }
}
