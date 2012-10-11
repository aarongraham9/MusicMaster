using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Models
{
    public class UserModel
    {
        #region Private Variables

        private string username;
        private string password;

        #endregion

        #region Constructors

        public UserModel() { }

        public UserModel(string usernameIn, string passwordIn) 
        {
            this.username = usernameIn;
            this.password = passwordIn;

        }

        #endregion

        #region Accessors

        public string Username
        {
            get { return username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return password; }
            set { this.password = value; }
        }

        #endregion
    }
}
