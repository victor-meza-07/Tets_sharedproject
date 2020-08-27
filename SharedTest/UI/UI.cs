using System;
using System.Collections.Generic;
using System.Text;

namespace SharedTest.UI
{
    static class UI
    {
        public static void PrintRegisterPrompt() 
        {
            Console.WriteLine("Please Register");
        }
        public static void PrintUserNamePrompt() 
        {
            Console.WriteLine("Please Enter Username");
        }
        public static void PrintPasswordPrompt() 
        {
            Console.WriteLine("Please Enter Password");
        }
        public static void PrintConfirmPasswordPrompt()
        {
            Console.WriteLine("Please Enter Password Again");
        }
        public static void PrintMessage(string message) 
        {
            Console.WriteLine(message);
        }
    }
}
