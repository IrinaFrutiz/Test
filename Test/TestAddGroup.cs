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
            HomePage();
            Login(new LoginData("admin", "secret"));
            GoToGroupPage();
            CreateGroup();
            FillInfoInGroup(new GroupData("aaa", "sss", "ddd"));
            SubmitGroup();
            ReturnToGroupPage();
            Logout();
        }
    }
}
