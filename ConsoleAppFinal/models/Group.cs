
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFinal
{
    class Group
    {
        public string No;
        public Category Categories;
        public bool IsOnline;
        public List<Student> Students;
        public int Limit;
       
        //public static int count = 127;
        //public static int count1 = 101;
        //public static int count2 = 334;
        public Group(int limit ,Category categories, string no,bool isOnline)
        {

            switch (Categories)
            {
                case Category.Programming:
                    No = $"Programming-{no}";
                    break;
                case Category.Design:
                    No = $"Design-{no}";

                    break;
                case Category.System_Administration:
                    No = $"Sosial-{no}";

                    break;
                default:
                    break;
                    
            }
            Categories = categories;
            isOnline = false;
            No = no;
            Limit = limit;




        }
        public override string ToString()
        {
            return $"no:{No}, Category:{Categories}";
        }
    }

}