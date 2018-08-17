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
    public class ManagerAplic
    {

        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;

        protected Helper_Login helper_Login;
        protected HelperNavi helper_Navigation;
        protected Helper_Group helper_Group;

        public ManagerAplic()
        {
            helper_Login = new Helper_Login(driver);
            helper_Navigation = new HelperNavi(driver, baseURL);
            helper_Group = new Helper_Group(driver);
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception exception)
            {
                //tratata
            }
        }

        public Helper_Login Auth
        {
            get
            {
                return helper_Login;
            }
        }

        public HelperNavi Navi
        {
            get
            {
                return helper_Navigation;
            }
        }
        public Helper_Group Groups
        {
            get
            {
                return helper_Group;
            }
        }
    }
}
