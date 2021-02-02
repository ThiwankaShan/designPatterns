using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class User
    {

        private string _name;

        private string _password;

        public string Name { 
            get {
                return _name;
            } 
            set {
                _name = value;
            } 
        }

        public string Password {
            get {
                return _password;
            }

            set
            {
                _password = Convert.ToBase64String(Encoding.UTF8.GetBytes(value));
            }
        }

    }
}
