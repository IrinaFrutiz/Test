using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class Helper_Group : Helper_Base 
    {
    
        public Helper_Group(IWebDriver driver) : base (driver)
        {
        
        }
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

        public void ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }
        public void DeleteGroup(int index)
        {
            driver.FindElement(By.Name("selected[]")).Click();
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            driver.FindElement(By.Name("selected[]")).Click();
            driver.FindElement(By.XPath("(//input[@name='delete'])[2]")).Click();
        }
        public void SubmitGroup()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        public void FillInfoInGroup(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }

        public void CreateGroup()
        {
            driver.FindElement(By.Name("new")).Click();
        }
    }
}
