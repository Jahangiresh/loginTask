using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFinal

{
     interface IServiceCode
    {
        public List<Group> Groups { get; }
        public List<Student> Students { get; }
        public string CreateGroup(int limit,Category categories, string no,bool isOnline);
        public void ShowGroups();
        public void EditGroupName(string no, string newNo);
        public void GetGroupStudents(string no);
        public void GetAllStudents(List<Student> Students);
        public string CreateStudent(string fullname,string groupNo);


    }
}