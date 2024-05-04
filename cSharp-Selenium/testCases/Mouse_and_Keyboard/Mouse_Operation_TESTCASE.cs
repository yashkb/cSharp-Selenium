using AventStack.ExtentReports;
using cSharp_Selenium.Base;
using cSharp_Selenium.pages.Mouse_and_Keyboard;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Selenium.testCases.Mouse_and_Keyboard
{
    internal class Mouse_Operation_TESTCASE :BaseClass
    {
        IWebDriver driver;
        Mouse_Operations_PAGE obj;
        string hoverURL = "https://the-internet.herokuapp.com/hovers";
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            obj = new Mouse_Operations_PAGE(driver);
            driver.Url = hoverURL;
        }
        [Test] 
        public void TC_001_Hover_Internet_herokuapp()
        {
            TestLogger.LogInfo("Starting TestLogin.");  
            obj.hoverActionPracticeWithReport();
            _test.Log(Status.Pass, "Hover");
        }

        [Test]
        public void TC_002_Hover_Internet_herokuapp()
        {
            obj.hoverActionPracticeWithReport();
            _test.Log(Status.Pass, "Hover-2");
        }

        [TearDown] 
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}
