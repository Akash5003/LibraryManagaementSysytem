using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSysytem
{
    internal class jasondata
    {
       
        public static void AddUser()
        {
            Console.WriteLine("Enter the usename:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the password:");
            string password = Console.ReadLine();
            Console.WriteLine("Re-enter the password:");
            string confirmpassword = Console.ReadLine();
            if(password== confirmpassword)
            {
                //this line is used to converting the json file to string.......
                string json = File.ReadAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\userlogin.json");

                //this line is used to converting the json string to object.....
                List<UserLoginDetails> userdata = JsonConvert.DeserializeObject<List<UserLoginDetails>>(json);

                //adding data..
                UserLoginDetails objUserLoginDetails = new UserLoginDetails(name,password);
                userdata.Add(objUserLoginDetails);

                //this line is used for resaving obj to json string...
                string json2 = JsonConvert.SerializeObject(userdata, Formatting.Indented);

                //json string to json file...
                File.WriteAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\userlogin.json", json2);

                Console.WriteLine("user added successfully");

            }
            else
            {
                Console.WriteLine("password mismatch");
            }

        }

        public static void RemoveUser()
        {
            
            string json = File.ReadAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\userlogin.json");

            List<UserLoginDetails> users= JsonConvert.DeserializeObject<List<UserLoginDetails>>(json);
            int a = 1;
            foreach(var i in users)
            {
                Console.Write(a+": usernames: "+i.username);
                Console.WriteLine(" passwords: "+i.password);
                Console.WriteLine("_______________________________________________________________");
                a++;
            }
            Console.WriteLine("enter user number:");
            int peru= Convert.ToInt32(Console.ReadLine());
            users.RemoveAt(peru-1);
            string json2 = JsonConvert.SerializeObject(users, Formatting.Indented);


            File.WriteAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\userlogin.json", json2);
            Console.WriteLine("user deleted successfully");
            Console.WriteLine("_______________________________________________________________");

        }
        public static void viewusers()
        {

            string json = File.ReadAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\userlogin.json");

            List<UserLoginDetails> users = JsonConvert.DeserializeObject<List<UserLoginDetails>>(json);
            int a = 1;
            foreach (var i in users)
            {
                Console.Write(a + ": usernames: " + i.username);
                Console.WriteLine(" passwords: " + i.password);
                Console.WriteLine("_______________________________________________________________");
                a++;
            }
            

        }
        public static void AddBook()
        {
            Console.WriteLine("enter the BookName:");
            string Bname = Console.ReadLine();
            Console.WriteLine("enter the Authorname:");
            string Aname = Console.ReadLine();

            
            string json = File.ReadAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\bookdetails.json");

            List<Bookdetails> bookdata = JsonConvert.DeserializeObject<List<Bookdetails>>(json);
            Bookdetails objbookDetails = new Bookdetails(Bname, Aname);
            bookdata.Add(objbookDetails);
            string json2 = JsonConvert.SerializeObject(bookdata, Formatting.Indented);


            File.WriteAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\bookdetails.json", json2);

            Console.WriteLine("book added successfully");
            Console.WriteLine("_______________________________________________________________");


         }
        public static void RemoveBook()
        {

            string json = File.ReadAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\bookdetails.json");

            List<Bookdetails> books = JsonConvert.DeserializeObject<List<Bookdetails>>(json);
            int a = 1;
            foreach (var i in books)
            {
                Console.Write(a + ": Book: " + i.BookName);
                Console.WriteLine("  Author: " + i.Authorname);
                Console.WriteLine("_______________________________________________________________");
                a++;
            }
            Console.WriteLine("enter book number:");
            int peru = Convert.ToInt32(Console.ReadLine());
            books.RemoveAt(peru - 1);
            string json2 = JsonConvert.SerializeObject(books, Formatting.Indented);


            File.WriteAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\bookdetails.json", json2);
            Console.WriteLine("Book Deleted Succesfully");
            Console.WriteLine("_______________________________________________________________");
        }
        public static void Viewbook()
        {
            string json = File.ReadAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\bookdetails.json");

            List<Bookdetails> books = JsonConvert.DeserializeObject<List<Bookdetails>>(json);
            int a = 1;
            foreach (var i in books)
            {
                Console.Write(a + ": Book: " + i.BookName);
                Console.WriteLine("  Author: " + i.Authorname);
                Console.WriteLine("_______________________________________________________________");
                a++;
            }
        }
        public static void Searchbook() 
        {
            Console.Write("Enter book name:");
            string book=Console.ReadLine();
            

            string json = File.ReadAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\bookdetails.json");

            List<Bookdetails> books = JsonConvert.DeserializeObject<List<Bookdetails>>(json);
            bool avail = false;
            foreach (var i in books)
            {
                if (book == i.BookName)
                {
                    Console.WriteLine("_______________________________________________________________");
                    Console.Write( ": Book: " + i.BookName);
                    Console.WriteLine("  Author: " + i.Authorname);
                    Console.WriteLine("_______________________________________________________________");
                    avail = true;
                    break;
                }
                
            }
            if (!avail)
            {
                Console.WriteLine("enter valid Bookname");
                Console.WriteLine("_______________________________________________________________");
                Searchbook();
                    
            }
        }
        public static void BarrowBook()
        {
            string json = File.ReadAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\bookdetails.json");

            List<Bookdetails> books = JsonConvert.DeserializeObject<List<Bookdetails>>(json);
            int a = 1;
            foreach (var i in books)
            {
                Console.Write(a + ": Book: " + i.BookName);
                Console.WriteLine("  Author: " + i.Authorname);
                Console.WriteLine("_______________________________________________________________");
                a++;
            }
            Console.WriteLine("enter book number:");
            int peru = Convert.ToInt32(Console.ReadLine());
            string json2 = File.ReadAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\barrowdetails.json");

            List<BarrowDetails> bhistory = JsonConvert.DeserializeObject<List<BarrowDetails>>(json2);

           
            BarrowDetails objBarrowDetails = new BarrowDetails(User.currentuser, books[peru-1].BookName,DateTime.Now);
            bhistory.Add(objBarrowDetails);
            string json3 = JsonConvert.SerializeObject(bhistory, Formatting.Indented);
           

            File.WriteAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\barrowdetails.json", json3);
            Console.WriteLine("Book Barrowed Successfully");
            Console.WriteLine("_______________________________________________________________");
        }
        public static void BarrowHistory()
        {
            string json = File.ReadAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\barrowdetails.json");

            List<BarrowDetails> books = JsonConvert.DeserializeObject<List<BarrowDetails>>(json);
            int a = 1;
            foreach (var i in books)
            {
                Console.WriteLine(a+" username: " + i.username);
                Console.Write( " Book: " + i.BookName);
                Console.WriteLine("  Author: " + i.Barrowdate);
                Console.WriteLine("_______________________________________________________________");
                a++;
            }

        }
        public static void UserBarrowedHistory()
        {

            string json = File.ReadAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\barrowdetails.json");

            List<BarrowDetails> books = JsonConvert.DeserializeObject<List<BarrowDetails>>(json);
            int a = 1;
            foreach (var i in books)
            {
                if (i.username == User.currentuser)
                {
                    Console.WriteLine(a + " username: " + i.username);
                    Console.Write(" Book: " + i.BookName);
                    Console.WriteLine("  Author: " + i.Barrowdate);
                    Console.WriteLine("_______________________________________________________________");
                    a++;
                }

            }
        }
        public static void ReturnBook()
        {
            UserBarrowedHistory();
            Console.Write("Enter th Book number which you want to Return:");
            int peru = Convert.ToInt32(Console.ReadLine());
            string json2 = File.ReadAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\barrowdetails.json");

            List<BarrowDetails> bhistory = JsonConvert.DeserializeObject<List<BarrowDetails>>(json2);
            int a = 1;
            foreach (var i in bhistory)
            {
                if (i.username == User.currentuser)
                {
                   
                    if (a == peru )
                    {
                        bhistory.Remove(i);
                        break;
                    }
                    a++;

                }

            }
           
            string json3 = JsonConvert.SerializeObject(bhistory, Formatting.Indented);


            File.WriteAllText(@"C:\Users\10Decoders\source\repos\LibraryManagementSysytem\LibraryManagementSysytem\jasonData\barrowdetails.json", json3);
            Console.WriteLine("Book Returned Successfully");
            Console.WriteLine("_______________________________________________________________");
        }
        

    }
}
