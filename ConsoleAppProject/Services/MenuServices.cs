using ConsoleAppProject.ApplicationServices;
using ConsoleAppProject.Enum;
using System;

namespace ConsoleAppProject.Services
{
    public static class MenuServices
    {
        public static IApplicationService service = new ApplicationService();
        public static void CreatGroupMenu()
        {
            foreach (Category c in System.Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine($"{(int)c}. {c}");
            }
            int number;
            string strNumb = Console.ReadLine();
            bool result = int.TryParse(strNumb, out number);

            if (result)
            {
                switch (number)
                {
                    case (int)Category.Programming:
                        Console.WriteLine(service.CreateGroup(Category.Programming));
                        break;
                    case (int)Category.Design:
                        Console.WriteLine(service.CreateGroup(Category.Design));
                        break;
                    case (int)Category.SystemAdministration:
                        Console.WriteLine(service.CreateGroup(Category.SystemAdministration));
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please choose valid number");
            }


        }
        public static void ShowGroupsMenu()
        {
            service.GetAllGroups();
        }
        public static void EditGroupsMenu()
        {

            Console.WriteLine("Please choose group no");
            string no = Console.ReadLine();
            Group group = service.FindGroup(no);
            if (group == null)
            {
                Console.WriteLine("There is not group ");
                return;
            }
            Console.WriteLine("Please choose new group no");
            string newNo = Console.ReadLine();
            var validationMessage = service.CheckGroup(newNo);

            if (!string.IsNullOrEmpty(validationMessage))
            {
                Console.WriteLine(validationMessage);
                return;
            }
            service.EditGroups(no, newNo);

            Console.WriteLine($"Your group name has been changed to : {newNo}");
        }
        //public static void ShowGroupsStudentsMenu()
        //{
        //    service.ShowGroupsStudents();
        //}
        //public static void ShowAllStudentsMenu()
        //{
        //    service.ListOfStudents();
        //}

        public static void CreateStudentsMenu()
        {
            var groups = service.GetAllGroups();

            if (groups.Count == 0)
            {
                Console.WriteLine("Groups is not exists. Please create group as first");
                return;
            }
            Console.WriteLine("Please enter any number of group");

            string groupNumber = Console.ReadLine();
            var currentGroup = service.FindGroup(groupNumber);

            if (currentGroup == null)
            {
                Console.WriteLine("Please type correct group number");
                return;
            }

            Console.WriteLine("Please enter student's fullname");
            string fullname = Console.ReadLine();
            var fullnameIsValid = service.CheckFullname(fullname);

            if (!fullnameIsValid) return;

            Console.WriteLine("Please choose is Warrianted");
            Console.WriteLine("1.Warrianted");
            Console.WriteLine("2.Unwarrianted");
            int warrianteStatus;
            string warNumber = Console.ReadLine();
            bool result = int.TryParse(warNumber, out warrianteStatus);
            if (!result)
            {
                Console.WriteLine("Please choose correct type");
                return;
            }
            if (warrianteStatus != 1 && warrianteStatus != 2)
            {
                Console.WriteLine("Please choose correct type");
                return;
            }

            bool warriante = warrianteStatus == 1;

            Student student = new Student(fullname, warriante);

            service.CreateStudent(student, currentGroup);
        }
    }
}
