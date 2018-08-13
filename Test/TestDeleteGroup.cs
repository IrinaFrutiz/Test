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
            helper_Navigation.HomePage();
            helper_Login.Login (new LoginData("admin", "secret"));
            helper_Navigation.GoToGroupPage();
            helper_Group.DeleteGroup(1);
            helper_Navigation.GoToGroupPage();
            helper_Login.Logout();
        }
    }
}
