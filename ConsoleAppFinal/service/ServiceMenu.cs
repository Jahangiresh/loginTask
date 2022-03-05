using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFinal.service
{
    static class ServiceMenu
    {
        public static ServiceCode serviceCode=new ServiceCode();
        public static void CreateGroupMenu()
        {
           
            Console.WriteLine("qrup no daxil edin");
            string no;
            no = Console.ReadLine();
            

            if (serviceCode.CheckGroup(no))
            {
                int limit;
                bool isOnline = false;
                Console.WriteLine("1.online\n2.offline");
                string strLimit = Console.ReadLine();
                bool resultLimit = int.TryParse(strLimit, out limit);

                switch (limit)
                {
                    case 1:
                        isOnline = true;
                        break;
                    case 2:
                        isOnline = false;
                        break;
                    default:
                        Console.WriteLine("choose fucking valid num! fucking 1 or fucking 2 PLEASE ");
                        break;
                }

                foreach (Category c in System.Enum.GetValues(typeof(Category)))
                {
                    Console.WriteLine($"{(int)c} {c}");
                }
                int category;
                string catStr = Console.ReadLine();
                bool resultCat = int.TryParse(catStr, out category);
               
                if (resultCat)
                {

                    switch (category)
                    {
                        
                        case (int)Category.Programming:
                          
                            string No = serviceCode.CreateGroup(limit, Category.Programming, no, isOnline);
                            Console.WriteLine($"{No} group succesfully created");
                            break;
                        case (int)Category.Design:
                       
                             No = serviceCode.CreateGroup(limit, Category.Design, no, isOnline);
                            Console.WriteLine($"{No} group succesfully created");
                            break;
                        case (int)Category.System_Administration:
                          
                             No = serviceCode.CreateGroup(limit, Category.System_Administration, no, isOnline);
                            Console.WriteLine($"{No} group succesfully created");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("please choose valid category");
                }
            }

        }
        public static void EditGroupMenu()
        {
            Console.WriteLine("qrupun adini yaz");
            string no = Console.ReadLine();
            Console.WriteLine("yeni qrup adi yaz");
            string newNo = Console.ReadLine();
           serviceCode.EditGroupName(no, newNo);
        }
        public static void ShowGroupsMenu()
        {
            serviceCode.ShowGroups();
        }
        public static void GetGroupStudentsMenu()
        {
            Console.WriteLine("qrupun adini yaz");
            string no = Console.ReadLine();
            serviceCode.GetGroupStudents(no);
        }
        public static void GetAllStudentsMenu()
        {
            
            serviceCode.GetAllStudents(serviceCode.Students);
        }
        public static void CreateStudentMenu()
        {
           
            Console.WriteLine("Telebenin ad soyadi");
            string fullname = Console.ReadLine();
            if (serviceCode.CheckStudentName(fullname))
            {
                Console.WriteLine("zzor");
            }
            else
            {
                Console.WriteLine("yox sehvdi");
            }
        }
    }
}
