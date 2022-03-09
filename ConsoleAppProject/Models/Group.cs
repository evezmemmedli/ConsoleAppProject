using ConsoleAppProject.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    public class Group
    {
        public string No;
        public int Limit;
        public static int Count = 100;
        public Category Category;
        public bool IsOnline;
        public List<Student> Students = new List<Student>();
        public Group(Category category)
        {

            switch (category)
            {
                case Category.Programming:
                    No = $"P-{Count}";
                    break;
                case Category.Design:
                    No = $"D-{Count}";
                    break;
                case Category.SystemAdministration:
                    No = $"S-{Count}";
                    break;

                default:
                    break;
            }
            Count++;
            Category = category;

        }
        public void SetGroupStatus(bool isOnline)
        {
            IsOnline = isOnline;
            Limit = isOnline ? 15 : 10;
        }
        public override string ToString()
        {
            string onlineStatus = IsOnline ? "Yes" : "No";
            return @$"GroupNo : {No}
                      GroupLimit : {Limit}
                      Category : {Category}
                      IsOnline : {onlineStatus}";
        }
    }
}
