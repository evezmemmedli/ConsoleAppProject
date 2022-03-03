using ConsoleAppProject.ApplicationServices;
using ConsoleAppProject.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.Services
{
    class Appservices : IAppServices
    {
        private List<Group> _groups = new List<Group>(); 
        public List<Group> Groups => _groups;

        public string CreatGroup(string no, Categories category , bool isOnline)
        {
            if (no.Length!=4 || !char.IsUpper(no[0]))
            {
                return "Please choose correct length ";
            }
            for (int i = 0; i < no.Length; i++)
            {
                if (!char.IsDigit(no[i]))
                {
                    return "Please add three number after capital letter";
                }
            }
            Group group = new Group(category, no, isOnline);
            group.Add(group);
            return group.No;

        }

        public string CreatStudent()
        {
            throw new NotImplementedException();
        }

        public void EditGroups()
        {
            throw new NotImplementedException();
        }

        public void GetAllGroups()
        {
            throw new NotImplementedException();
        }

        public void ListOfStudents()
        {
            throw new NotImplementedException();
        }

        public void ShowGroupsStudents()
        {
            throw new NotImplementedException();
        }
    }
}
