﻿using System;
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
            manA.Navi.HomePage();
            manA.Auth.Login (new LoginData("admin", "secret"));
            manA.Navi.GoToGroupPage();
            manA.Groups.DeleteGroup(1);
            manA.Navi.GoToGroupPage();
            manA.Auth.Logout();
        }
    }
}
