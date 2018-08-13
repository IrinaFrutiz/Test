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
     public class HelperNavi : Helper_Base 
    {
        private string baseURL;
        public class HelperNavi(IWebDriver driver, string baseURL)
            :base (driver)
        {
            this.baseURL = baseURL;
        }
        public  void HomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "addressbook/");
        }

        public  void GoToGroupPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
