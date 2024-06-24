using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibraryManagementSysytem
{
    internal class Librarian
    {
       public static void  LibrarianLogin() 
        {

            Console.Write("Enter username:");
            string UserName = Console.ReadLine();
            Console.Write("Enter Password:");
            string Password = Console.ReadLine();
            if (UserName == "10decoders" && Password == "12345")
            {
                Console.WriteLine("log in successfull!");
                LibrarianLoginChoice();
            }
            else
            {
                Console.WriteLine("Enter valid username and password!");
                LibrarianLogin();

            }


        }
        public static void LibrarianLoginChoice() 
        {
            Console.WriteLine("1.Book Management");
            Console.WriteLine("2.User Management");
            Console.WriteLine("3.Borrow History");
            Console.WriteLine("4.Log out");
            Console.Write("Enter your choice:");
            string UserChoice = Console.ReadLine();
            switch (UserChoice)
            {
                case "1":
                    BookManagement();
                    break;
                case "2":
                    UserManagement();


                    break;
                case "3":
                    jasondata.BarrowHistory();
                    LibrarianLoginChoice();

                    break;
                
                case "4":
                    Program.Main();

                    break;
                default:
                    Console.WriteLine("Enter valid choice!");
                    LibrarianLoginChoice();

                    break;
            }
        }
        public static void UserManagement()
        {
            Console.WriteLine("1.Add User");
            Console.WriteLine("2.Delete user");
            Console.WriteLine("3.view users");
            Console.WriteLine("4.log out");
            Console.Write("Enter your choice:");
            string urchoice= Console.ReadLine();
            switch (urchoice)
            {
                case "1":
                    jasondata.AddUser();
                    UserManagement();
                    break;
                case "2":
                    jasondata.RemoveUser();
                    UserManagement();

                    break;
                case "4":
                    Program.Main();
                    

                    break;
                case "3":
                    jasondata.viewusers();
                    UserManagement();

                    break;
                default:
                    Console.WriteLine("Enter valid choice!");
                    UserManagement();
                    break;

            }     
        }
        public static void BookManagement()
        {
            Console.WriteLine("1.Add Book");
            Console.WriteLine("2.Remove Book");
            Console.WriteLine("3.view book");
            Console.WriteLine("4.search book by name");
            string urchoice = Console.ReadLine();
            switch (urchoice)
            {
                case "1":
                    jasondata.AddBook();
                    BookManagement();

                    break;
                case "2":
                    jasondata.RemoveBook();
                    BookManagement();
                    break;
                case "3":
                    jasondata.Viewbook();
                    BookManagement();
                    break;
                case "4":
                    jasondata.Searchbook();
                    BookManagement();
                    break;
                default:
                    Console.WriteLine("Enter valid choice!");
                    UserManagement();
                    break;

            }
        }
        
    }
}

