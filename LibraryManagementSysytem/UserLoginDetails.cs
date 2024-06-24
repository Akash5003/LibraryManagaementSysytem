using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSysytem
{
    internal class UserLoginDetails
    {
       public string username;
        public string password;

       public UserLoginDetails(string uname, string pass)
        {
            this.username = uname;
            this.password = pass;
            
        }


    }
}
