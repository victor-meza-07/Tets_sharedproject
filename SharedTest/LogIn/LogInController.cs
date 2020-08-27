using System;
using System.Collections.Generic;
using System.Text;
using SharedTest.UI;

namespace SharedTest.LogIn
{
    public class LogInController
    {
        public string username { get; set; }
        public string password { get; set; }
        public LogInController()
        {

        }

        /// <summary>
        /// Collects username and password from params and sets properties to those values.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void RegisterUser(string username, string password) 
        {
            
        }

        /// <summary>
        /// Tests Username and Password passed as params against object properties of the same name.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pasword"></param>
        /// <returns></returns>
        public bool LogUserIn(string username, string pasword) 
        {
            if (username == this.username && password == this.password) 
            {
                return true;
            }
            return false;
        }
    }
}
