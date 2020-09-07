using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Login
    {
        private string username;

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private int role;

        public int Role
        {
            get { return role; }
            set { role = value; }
        }
    }



    
}
