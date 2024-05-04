using cSharp_Selenium.pages.Work_with_Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Selenium.testCases.Work_with_Data
{
    internal class FileUpload_TESTCASE
    {
        IWebDriver driver;
        FileUpload_PAGE obj;
        [SetUp] 
        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void TC_001_chooseFileBtn()
        {
            obj = new FileUpload_PAGE(driver);
            obj.getChooseFileBtn();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}
