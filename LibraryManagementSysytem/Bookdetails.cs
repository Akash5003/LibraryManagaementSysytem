using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSysytem
{
    internal class Bookdetails
    {

        public string BookName;
        public string Authorname;

        public Bookdetails(string bname, string author)
        {
            this.BookName = bname;
            this.Authorname = author;
        }
    }
}
