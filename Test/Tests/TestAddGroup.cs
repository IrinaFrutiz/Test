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
            manA.Navi.HomePage();
            manA.Auth.Login(new LoginData("admin", "secret"));
            manA.Navi.GoToGroupPage();
            manA.Groups.CreateGroup();
            manA.Groups.FillInfoInGroup(new GroupData("aaa", "sss", "ddd"));
            manA.Groups.SubmitGroup();
            manA.Navi.GoToGroupPage();
            manA.Auth.Logout();
        }
    }
}
