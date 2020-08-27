using NUnit.Framework;
using SharedTest;

namespace CorrectUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestLogIn()
        {
            SharedTest.LogIn.LogInController controller = new SharedTest.LogIn.LogInController();
            controller.username = "a";
            controller.password = "b";
            string username = "b";
            string password = "                                                                                                       ";
            bool expected = false;
            bool actual = controller.LogUserIn(username, password);

            Assert.AreEqual(expected, actual);
        }
    }
}