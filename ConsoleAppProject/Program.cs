using ConsoleAppProject.ApplicationServices;
using ConsoleAppProject.Services;
using System;


namespace ConsoleAppProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cinema Application\n");
            int selection;
            do
            {
                Console.WriteLine("1.Create Group");
                Console.WriteLine("2.Show Groups");
                Console.WriteLine("3.Edit Group");
                Console.WriteLine("4.Show Students in Group");
                Console.WriteLine("5.Show all students");
                Console.WriteLine("6.Create students");
                Console.WriteLine("7.Exit");
                string strSelection = Console.ReadLine();
                bool result = int.TryParse(strSelection, out selection);

                if (true)
                {
                    Console.WriteLine();
                    switch (selection)
                    {
                        case 1:
                            {
                                MenuServices.CreatGroupMenu();
                                break;
                            }
                        case 2:
                            {
                                MenuServices.ShowGroupsMenu();
                                break;

                            }
                        case 3: 
                            {
                            MenuServices.EditGroupsMenu();
                                break;
                            }
                        //case 4:
                        //    {
                        //        MenuServices.ShowGroupsStudentsMenu();
                        //        break;
                        //    }
                        //case 5:
                        //    {
                        //        MenuServices.ShowAllStudentsMenu();
                        //        break;
                        ////    }
                        case 6:
                            {
                                MenuServices.CreateStudentsMenu();
                                break;
                            }

                        default:
                            Console.WriteLine("Please choose valid number");
                            break;
                    }
                }
            } while (selection != 0);
        }
    }
}
