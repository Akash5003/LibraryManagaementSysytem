using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSysytem
{
    internal class User
    {
        public static string currentuser = null;
        public static void userlogin()
        {
            Console.Write("Enter username:");
            string UserName=Console.ReadLine();
            Console.Write("Enter Password:");
            string Password=Console.ReadLine();
            string json = File.ReadAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\userlogin.json");

            List<UserLoginDetails> users = JsonConvert.DeserializeObject<List<UserLoginDetails>>(json);
            bool user = false;
            foreach (var i in users)
            {
                if (UserName == i.username && Password==i.password)
                {
                    Console.WriteLine("log in successfull!");
                    user = true;
                    currentuser=i.username;
                    userloginchoice();
                    break;
                }

            }

            
            if(!user) 
            {
                Console.WriteLine("Enter valid username and password!");
                userlogin();

            }

        
        }
        public static void userloginchoice()
        {
            Console.WriteLine("1.View Available books");
            Console.WriteLine("2.Borrow books");
            Console.WriteLine("3.Return books");
            Console.WriteLine("4.view barrowed books");
            Console.WriteLine("5.Home");
            string UserChoice=Console.ReadLine();
            switch (UserChoice)
            {
                case "1":
                    jasondata.Viewbook();
                    userloginchoice();
                    break;
                case "2":
                    jasondata.BarrowBook();
                    userloginchoice();
                    break;
                case "3":

                    jasondata.ReturnBook();
                    userloginchoice();
                    
                    break;
                case "4":
                    jasondata.UserBarrowedHistory();
                    userloginchoice();
                     break;
                case "5":
                    Program.Main();
                  
                    break;
                default:
                    Console.WriteLine("Enter valid choice!");
                    userloginchoice();

                    break;
            }
         

        }
        public static void AvailaBooks()
        {
            Console.WriteLine("The Available books");
        }
    }
}
