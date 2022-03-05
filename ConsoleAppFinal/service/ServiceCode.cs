using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFinal
{
    class ServiceCode : IServiceCode
    {
        private List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;
        private List<Student> _students => new List<Student>();
        public List<Student> Students => _students;
        public bool CheckGroup(string no)
        {
            for (int i = 0; i < no.Length; i++)
            {

                if (no.Length == 4 && char.IsUpper(no[0]) && char.IsDigit(no[++i]))
                {
                    return true;
                }

                else
                {
                    Console.WriteLine("Qrup adi 1 boyuk her ve 3 reqemden ibaret olmalidir"); break;
                }
            }
            return false;
        }
        public bool CheckStudentName(string fullname)
        {
            if (fullname.Length==2)
            {
                string[] subs = fullname.Split(' ');
                string name = subs[0];
                string surname = subs[1];
                //string name1 = "";
                //string surname1 = "";
                fullname = name + ' ' + surname;
                for (int i = 0; i < name.Length; i++)
                {

                    if (char.IsUpper(name[0]) && char.IsLower(name[++i]))
                    {
                        name = subs[0];
                    }            
                }
                for (int i = 0; i < surname.Length; i++)
                {
                    if ((char.IsUpper(surname[0]) && char.IsLower(surname[++i])))
                    {
                        surname = subs[1];
                    }
                }
                if (name + surname == subs[0] + subs[1])
                {
                    return true;
                }
            }
            return false;
        }
        public string CreateGroup(int limit,Category categories, string no, bool isOnline )
        {
           
            CheckGroup(no);


            if (isOnline)
            {
                limit = 10;
            }
            if (!isOnline)
            {
                limit = 10;
            }
            Group group = new Group(limit,categories, no,isOnline);
            Groups.Add(group);
            return group.No;
        }

       
        public void ShowGroups()
        {
            if (_groups.Count == 0)
            {
                Console.WriteLine("there is no group in this Academy");
                return;
            }
            foreach (Group group in _groups)
            {
                Console.WriteLine(group);
            }
        }

        public void EditGroupName(string no, string newNo)
        {
            Group existedGroup = FindGroup(no);

            if (existedGroup == null)
            {
                Console.WriteLine("plese choose correct grup num");
                return;
            }

            foreach (Group group in _groups)
            {
                if (group.No == newNo)
                {
                    Console.WriteLine($"{newNo} group is already exist");
                }
            }
            existedGroup.No = newNo;
            Console.WriteLine($"{no} succesfuly changed to {newNo}");
        }
        public Group FindGroup(string no)
        {
            foreach (Group group in _groups)
            {
                if (group.No == no)
                {
                    return group;
                }
            }
            return null;
        }

        public void GetGroupStudents(string no)
        {
            Group group = FindGroup(no);
            if (group == null)
            {
                Console.WriteLine("pls choosevalid group no");
                return;
            }
            if (Students.Count!=0)
            {
                foreach (Student student in group.Students)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("telebe yoxdu");
            }
            
        }
        public void GetAllStudents(List<Student> Students)
        {
            if (Students.Count!=0)
            {
                foreach (Student student in Students)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("kursda telebe yoxdi");
            }
           
        }


        public string CreateStudent(string fullname, string groupno)
        {
            if (fullname.Length == 2)
            {
                CheckStudentName(fullname);
            }
            else
            {
                return "ad ve ya soyad sehv yazilib";
            }
            Student student = new Student(fullname, groupno);
            Group group = Groups.Find(x => x.No.Trim().ToLower() == groupno.Trim().ToLower());
            group.Students.Add(student);
            Students.Add(student);
            return student.Fullname;

        }

      

     
    }
}