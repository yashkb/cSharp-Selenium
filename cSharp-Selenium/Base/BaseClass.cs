using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Selenium.Base
{
    public class BaseClass
    {

        protected IWebDriver _driver;
        ExtentSparkReporter spark;
        string path = @"C:\TestReport\report_CSharp_Selenium.html";
        ExtentReports extent;
        protected ExtentTest _test;

        
        [OneTimeSetUp]
        public void Setup()
        {
            extent = new ExtentReports();
            spark = new ExtentSparkReporter(path);
            extent.AttachReporter(spark);
        }

        [SetUp]
        public void CreateTest()
        {
            _driver = new ChromeDriver();
            _test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        public void NavigateURL(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            
            extent.Flush();
        }
        [TearDown] 
        public void TearDown2()
        {
            _driver.Dispose();
        }
        

        
    }
}
