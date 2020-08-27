using SharedTest.LogIn;
using System;

namespace SharedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Application will only have a 'log in' & 'Register' function ");
        }

        static void Control() 
        {
            LogInController controller = new LogInController();
            
        }

        
    }
}
