using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace task_tracking
{
    class User
    {
        private string _name;
        private string _surname;
        private string _email;
        private string _password;
        private string _login;
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public User(string login, string email, string password)
        {
            this._login = login;
            this._email = email;
            this._password = password;
        }
    }
}
