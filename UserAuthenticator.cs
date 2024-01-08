using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class UserAuthenticator
    {
        private Dictionary<string, string> userDatabase = new Dictionary<string, string>();

        public bool RegisterUser(string username, string password)
        {
            if (!userDatabase.ContainsKey(username))
            {
                userDatabase.Add(username, password);
                return true; // Registration successful
            }

            return false; // Username already exists
        }

        public bool LoginUser(string username, string password)
        {
            if (userDatabase.TryGetValue(username, out string storedPassword))
            {
                return password == storedPassword; // Login successful if passwords match
            }

            return false; // Username not found
        }

        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            if (userDatabase.TryGetValue(username, out string storedPassword) && storedPassword == oldPassword)
            {
                userDatabase[username] = newPassword;
                return true; // Password change successful
            }

            return false; // Either username not found or old password is incorrect
        }
    }
}
