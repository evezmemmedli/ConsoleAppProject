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
        public string GroupNo;
        public bool IsWarranted;

        public Student(string fullName, string groupNo, bool isWarranted)
        {
            FullName = fullName;
            GroupNo = groupNo;
            IsWarranted = false;

        }
    }
}
