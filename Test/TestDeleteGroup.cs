using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class TestDeleteGroup : BasicTest
    
    {
        [Test]
        public void Delete_Group_Test()
        {
            HomePage();
            Login (new LoginData("admin", "secret"));
            GoToGroupPage();
            DeleteGroup(1);
            ReturnToGroupPage();
            Logout();
        }
    }
}
