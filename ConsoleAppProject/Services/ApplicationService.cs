using ConsoleAppProject.ApplicationServices;
using ConsoleAppProject.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppProject.Services
{
    public class ApplicationService : IApplicationService
    {
        private List<Group> _groups = new List<Group>();

        private List<Student> _students = new List<Student>();

        public List<Group> Groups => throw new NotImplementedException();


        #region Group
        public Group CreateGroup(Category category)
        {

            Group group = new Group(category);
            Console.WriteLine("Enter group status");
            Console.WriteLine("1.Online");
            Console.WriteLine("2.Offline");

            int option;

        k:
            string inputValue = Console.ReadLine();
            bool parsedResult = int.TryParse(inputValue, out option);
            if (!parsedResult)
            {
                Console.WriteLine("Choose correct type a number");
                goto k;
            }
            if (option != 1 && option != 2)
            {
                Console.WriteLine("Choose correct valid");
                goto k;
            }


            bool isOnline = option == 1;

            group.SetGroupStatus(isOnline);

            _groups.Add(group);

            return group;

        }

        #endregion

        public void CreatStudent(string fullname, string groupNo, bool isWarranted)
        {

            if (!CheckFullname(fullname))
            {
                Console.WriteLine("Enter correct validation");
                return;
            }
            Student student = new Student(fullname, groupNo, isWarranted);
            _students.Add(student);
        }
        public bool CheckFullname(string fullname)
        {

            string[] splitFullname = fullname.Split(" ");
            if (fullname.Length == 2)
            {

                if (char.IsUpper(splitFullname[0][0]) && char.IsUpper(splitFullname[1][0]))
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            return false;

        }

        public void EditGroups(string no, string newNo)
        {
            Group existGroup = FindGroup(no);

            if (existGroup == null)
            {
                Console.WriteLine("Plese choose another version");
                return;
            }
            foreach (Group group in _groups)
            {
                if (group.No.ToLower().Trim() == newNo.ToLower().Trim())
                {
                    Console.WriteLine($"{newNo} group already exist");
                    return;
                }
                existGroup.No = newNo.ToUpper();
            }
        }
        public  string CheckGroup(string no)
        {
            if (string.IsNullOrWhiteSpace(no)) return "Group name cannot be empty";

            if (no.Length != 4) return "Group name must be 4 characters";

            if (!char.IsUpper(no[0])) return "Group name first letter must be capital ";

            for (int i = 1; i < no.Length; i++)
            {
                if (!char.IsDigit(no[i]))
                    return "Group name must be contain at least 3 digit number after capital letter.";
            }

            return string.Empty;
        }

        public void GetAllGroups(string no)
        {
            if (_groups.Count == 0)
            {
                Console.WriteLine("There is no group");
                return;
            }
            foreach (Group group in _groups)
            {
                Console.WriteLine(group);
            }

        }
        public Group FindGroup(string no)
        {
            foreach (Group group in _groups)
            {
                if (group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    return group;
                }
            }
            return null;
        }
        public void ListOfStudents()
        {
            if (_students.Count == 0)
            {
                Console.WriteLine("There is no student");
                return;
            }
            foreach (Student students in _students)
            {
                Console.WriteLine(students);
            }
        }

        public void ShowGroupsStudents(string no)
        {
            Group group = FindGroup(no);
            if (group == null)
            {
                Console.WriteLine("Plese enter existed group no");
                return;
            }
            foreach (Student student in group.Students)
            {
                Console.WriteLine(student);
            }

        }
    }
}
