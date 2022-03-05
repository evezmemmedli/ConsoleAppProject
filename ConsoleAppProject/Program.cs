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
                Console.WriteLine("4.Students count on Group");
                Console.WriteLine("5.Show all students");
                Console.WriteLine("6.Creat students");
                Console.WriteLine("7.Exit");
                string strSelection = Console.ReadLine();
                bool result = int.TryParse(strSelection, out selection);

                if (true)
                {
                    switch (selection)
                    {
                        case 1:
                            {
                                IApplicationService service = new ApplicationService();
                                var group = service.CreateGroup(Enum.Category.Design);

                                Console.WriteLine($"Created group number is: {group.No}\n");
                                Console.WriteLine($"Created group Online is: {group.IsOnline}\n");
                                Console.WriteLine($"Created group Limit is: {group.Limit}\n");

                                break;
                            }
                        default:
                            break;
                    }





                }
            } while (selection != 0);
        }
    }
}
