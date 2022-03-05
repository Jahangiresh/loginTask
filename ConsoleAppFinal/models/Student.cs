using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFinal

{
    class Student
    {
        public string Fullname;
        public string GroupNo;
        public bool isGaranty;
        public Student(string fullname, string groupno)
        {
            Fullname = fullname;
            GroupNo = groupno;
            isGaranty = false;
        }

        
        //public string checkFullname(string fullname)
        //{
        //    if (fullname.Contains(' '))
        //    {
        //        string[] subs = fullname.Split(' ');
        //        string name = subs[0];
        //        string surname = subs[1];
        //        string name1 = "";
        //        string surname1 = "";
        //        Fullname = name + ' ' + surname;
        //        for (int i = 0; i < name.Length; i++)
        //        {

        //            if (char.IsUpper(name[0]) && char.IsLower(name[++i]))
        //            {
        //                name = name1;
        //            }
        //            else
        //            {
        //                Console.WriteLine("adi tezeden yoxla"); break;
        //            }
        //        }
        //        for (int i = 0; i < surname.Length; i++)
        //        {
        //            if (char.IsUpper(surname[0]) && char.IsLower(surname[++i]))
        //            {
        //                surname = surname1;
        //            }
        //            else
        //            {
        //                Console.WriteLine("soy adi tezeden yoxla"); break;
        //            }
        //        }

        //    }
        //    return Fullname;
        //}
    }
}