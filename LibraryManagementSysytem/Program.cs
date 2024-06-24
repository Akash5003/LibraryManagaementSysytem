using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSysytem
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to our LIBRARY");
            Console.WriteLine("1.User log in");
            Console.WriteLine("2.Librarian log in");
            Console.WriteLine("3.Exit");
            Choices();
        }
        public static void Choices()
        {
            Console.Write("Enter your choice:");
            string choice = Console.ReadLine();
            Console.WriteLine("_______________________________________________________________");
            if (choice == "1")
            {
                User.userlogin();

            }
            else if (choice == "2")
            {
                Librarian.LibrarianLogin();
            }
            else if (choice == "3")
            {
                  Console.WriteLine("Thank you");
            }
            else
            {
                Console.WriteLine("Pease Enter a Valid Input");
                Choices();
            }

        }
    }
}
