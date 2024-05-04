using cSharp_Selenium.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Selenium.testCases
{
    internal class UserInteraction_TESTCASE 
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            // Initialize WebDriver instance (e.g., using ChromeDriver)
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
        }
        [Test]
        public void TC_001_A()
        {
            UserInteraction_PAGE obj = new UserInteraction_PAGE(driver);
            obj.rightClickJS();
            Thread.Sleep(5000);
        }


        [TearDown]
        public void CloseBrowser()
        {
            driver.Dispose();
        }

    }
}
