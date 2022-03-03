using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    internal class Students
    {
        public string FullName;
        public string GroupNo;
        public bool Type;

        public Students(string fullName,string groupNo)
        {
            FullName = fullName;
            GroupNo= groupNo;
            Type = false;

        }
    }
}
