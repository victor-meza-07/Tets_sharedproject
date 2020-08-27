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

        public void RegisterUser(string username, string password) 
        {
            this.username = username;
            this.password = password;
        }

        public void CollectUserInfo(string condition) 
        {
            switch (condition) 
            {
                case "login":
                    break;
                case "register":

                    break;
                default:
                    Console.WriteLine("That is not a valid case");
                    break;
            }
        }

        private void RegisterUser() 
        {
            string username, password, confirmPass;
            UI.UI.PrintUserNamePrompt();
            username = Console.ReadLine();
            UI.UI.PrintPasswordPrompt();
            password = Console.ReadLine();
            UI.UI.PrintConfirmPasswordPrompt();
            confirmPass = Console.ReadLine();

            Console.WriteLine("user Registered");
        }

        private string GetFunction() 
        {
            UI.UI.PrintMessage("Please enter the function to perform");
            Console.WriteLine("login or register");
            return Console.ReadLine();
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
