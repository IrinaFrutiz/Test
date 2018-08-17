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
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;

        protected Helper_Login helper_Login;
        protected HelperNavi navi;
        protected Helper_Group helper_Group;

        protected ManagerAplic manA;
        

        [SetUp]
        public void SetupTest()
        {
            manA = new ManagerAplic();
            //FirefoxOptions options = new FirefoxOptions();
            //options.BrowserExecutableLocation = @"c:\Ira\soft\Soft_for_test\FirefoxPortableESR\FirefoxPortable.exe";
            //options.UseLegacyImplementation = true;
            //driver = new FirefoxDriver(options);
            //baseURL = "http://localhost/";
            //verificationErrors = new StringBuilder();

            
        }

        [TearDown]

        public void TeardownTest()
        {
            manA.Stop();
        }
        
    }
}
