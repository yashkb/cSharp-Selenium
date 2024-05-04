using AventStack.ExtentReports;
using cSharp_Selenium.Base;
using cSharp_Selenium.pages.Locator;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Selenium.testCases.Locator
{
    internal class Handle_DropDown_TESTCASE : BaseClass
    {
        [SetUp]
        public void SetUp()
        {
            NavigateURL("https://chercher.tech/practice/practice-dropdowns-selenium-webdriver");
        }

        [Test]
        public void TC_001_SelectDropDown()
        {
            
            Handle_DropDown_PAGE obj= new Handle_DropDown_PAGE(_driver);
            
            obj.selectDropDown();
            _test.Log(Status.Pass, "Select 2nd Option");
        }
        [Test]
        public void TC_002_SelectDropDownByValue()
        {

            Handle_DropDown_PAGE obj = new Handle_DropDown_PAGE(_driver);

            obj.selectDropDownByValue();
            _test.Log(Status.Pass, "Select By Value");
        }
    }
}
