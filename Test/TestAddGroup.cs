using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class TestAddGroup : BasicTest
    {
        [Test]
        public void Add_Group_Test()
        {
            helper_Navigation.HomePage();
            helper_Login.Login(new LoginData("admin", "secret"));
            helper_Navigation.GoToGroupPage();
            helper_Group.CreateGroup();
            helper_Group.FillInfoInGroup(new GroupData("aaa", "sss", "ddd"));
            helper_Group.SubmitGroup();
            helper_Navigation.GoToGroupPage();
            helper_Login.Logout();
        }
    }
}
