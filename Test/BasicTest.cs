using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class BasicTest
    {
        protected  IWebDriver driver;
        private StringBuilder verificationErrors;
        protected  string baseURL;

        [SetUp]
        public void SetupTest()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"c:\Ira\soft\Soft_for_test\FirefoxPortableESR\FirefoxPortable.exe";
            options.UseLegacyImplementation = true;
            driver = new FirefoxDriver(options);
            baseURL = "http://localhost/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void GroupCreationTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {

            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        protected void HomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "addressbook/");
        }
        protected void Login(LoginData log)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(log.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(log.Password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }
        protected void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
        protected void GoToGroupPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
        protected void ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }
        protected void DeleteGroup(int index)
        {
            driver.FindElement(By.Name("selected[]")).Click();
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            driver.FindElement(By.Name("selected[]")).Click();
            driver.FindElement(By.XPath("(//input[@name='delete'])[2]")).Click();
        }
        protected void SubmitGroup()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        protected void FillInfoInGroup(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }

        protected void CreateGroup()
        {
            driver.FindElement(By.Name("new")).Click();
        }
    }
}
