using cSharp_Selenium.pages.Locator;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Selenium.testCases.Locator
{
    internal class Interacting_Web_Element_TestCases
    {
        IWebDriver driver = null;
        Interacting_Web_Element_Page obj;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            obj = new Interacting_Web_Element_Page(driver);
        }
        [Test]
        public void sendkeysAlternative()
        {
            
            obj.enterValue("Abc");
            
        }
        [Test]
        public void sendkeysJavascript()
        {
            
            obj.enterValueJavascript("Virat");
        }
        [Test]

        public void TC_003_ClearValueAlternative()
        {
            obj.clearValueAlternative();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}
