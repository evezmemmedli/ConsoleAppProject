using ConsoleAppProject.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.ApplicationServices
{
    public interface IApplicationService
    {
        public Group CreateGroup(Category category);
        public void GetAllGroups(string no);
        public void EditGroups(string no, string newNo);
        public void ShowGroupsStudents(string no);
        public void ListOfStudents();
        public void CreatStudent(string fullname, string gropNo, bool isWarranted);
    }
}
