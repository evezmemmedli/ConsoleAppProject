using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.ApplicationServices
{
     interface IAppServices
    {
        public List<Group> Groups { get; }
        public string CreatGroup();
        public void GetAllGroups();
        public void EditGroups();
        public void ShowGroupsStudents();
        public void ListOfStudents();
        public string CreatStudent();
    }
}
