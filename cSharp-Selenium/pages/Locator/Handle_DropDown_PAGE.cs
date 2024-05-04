using cSharp_Selenium.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Selenium.pages.Locator
{
    internal class Handle_DropDown_PAGE
    {
        protected IWebDriver driver;

        public Handle_DropDown_PAGE(IWebDriver driver)
        {
            this.driver = driver;
            
        }

        public void selectDropDown()
        {
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TitleContains("selenium"));
            
            IWebElement dropDownEle = driver.FindElement(By.XPath("//select[@id='first']"));
            SelectElement select = new SelectElement(dropDownEle);
            select.SelectByIndex(0);
            Thread.Sleep(3000);
            
            
        }

        public void selectDropDownByValue()
        {
            IWebElement dropDownEle = driver.FindElement(By.XPath("//select[@id='animals']"));
            SelectElement select = new SelectElement(dropDownEle);
            select.SelectByText("Avatar");
            Thread.Sleep(2000);
            
        }
    }
}
