using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Admin { get; set; }

        public User(string Username, string Password, int Admin)
        {
            this.Username = Username;
            this.Password = Password;
            this.Admin = Admin;
        }
    }
}
