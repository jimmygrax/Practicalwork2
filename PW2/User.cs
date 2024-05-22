using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW2
{
    public class User
    {
        private string name;
        private string password;
        private string username;
        private string email;
        public User() { }
        public User(string name, string username, string password, string email) // I parameterise the variables
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.email = email;
        }
        public string Printinfo() // Here's how to print what is written in the file
        {
            return $"{name};{username};{password};{email}";
        }

        public string GetName()
        {
            return name;
        }
        public string GetPassword()
        {
            return password;
        }
    }
}
