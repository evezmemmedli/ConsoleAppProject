using ConsoleAppProject.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    internal class Group
    {
        public string No;
        public int Limit;
        public static int Count = 1;
        public Categories Category;
        public bool IsOnline;
        public Students[] Student;

        public Group(Categories category, string no, bool isOnline)
        {

            switch (category)
            {
                case Categories.Programming:
                    No = $"Prog-{Count}";
                    break;
                case Categories.Design:
                    No = $"Desg-{Count}";
                    break;
                case Categories.SystemAdministration:
                    No = $"SysAdm-{Count}";
                    break;

                default:
                    break;
            }
            Count++;
            Category = category;
            if (isOnline == true)
            {
                Limit = 15;
            }
            else
            {
                Limit = 10;
            }

        }

        internal void Add(Group group)
        {
            throw new NotImplementedException();
        }
    }
}
