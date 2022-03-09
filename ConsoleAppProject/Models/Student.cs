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
        List<Student> Students;

        public Student()
        {

        }
        public Student(string fullName, bool isWarranted)
        {
            FullName = fullName;
            IsWarranted = isWarranted;

        }



        public override string ToString()
        {
            string warrantedStatus = IsWarranted ? "Yes" : "No";
            return $@"Fullname : {FullName}
                      IsWarranted : {warrantedStatus}";
        }
    }
}
