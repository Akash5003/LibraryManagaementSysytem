using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSysytem
{
    internal class BarrowDetails
    {
        public string username;
        public string BookName;
        public DateTime Barrowdate;

        public BarrowDetails(string uname,string bname,DateTime bdate)
            {
                this.username = uname;
               this.BookName = bname;
            this.Barrowdate = bdate;

            }

    }
}
