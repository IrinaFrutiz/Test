using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests

    public class Helper_Login : Helper_Base
{
    
    public Helper_Login (IWebDriver driver)
        : base(driver)
    {
    }
    public Helper_Login
    
        public void Login(LoginData log)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(log.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(log.Password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }
        public void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    
}
