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
    public class Helper_Base
    {
        protected IWebDriver driver;

        public Helper_Base(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
