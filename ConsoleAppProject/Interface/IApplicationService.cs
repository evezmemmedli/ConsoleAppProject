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
        public List<Group> GetAllGroups();
        public void EditGroups(string no, string newNo);
        public void ShowGroupsStudents(string no);
        public string CheckGroup(string no);
        public Group FindGroup(string no);
        public void ListOfStudents();
        public void CreateStudent(Student student, Group group);
        public bool CheckFullname(string fullname);
    }
}
