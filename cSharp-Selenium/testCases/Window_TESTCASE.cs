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
    internal class Window_TESTCASE
    {
        IWebDriver driver;
        Window_PAGE obj;
        [OneTimeSetUp]
        public void setUp()
        {
            driver = new ChromeDriver();
            
        }
        [Test]
        public void TC_001_A()
        {
            obj = new Window_PAGE(driver);
            obj.openWindow();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Console.WriteLine("closed window");
            driver.Close();
        }

        
    }
}
