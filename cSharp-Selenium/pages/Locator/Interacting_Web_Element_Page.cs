using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Selenium.pages.Locator
{
    internal class Interacting_Web_Element_Page
    {
        private IWebDriver driver;
        private IWebElement textAreaEle;
        public Interacting_Web_Element_Page(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void enterValue(string str)
        {
            textAreaEle = getTextAreaEle();
            textAreaEle.SendKeys(str);
            textAreaEle.SendKeys(Keys.Enter);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TitleContains("Search"));

        }

        private IWebElement getTextAreaEle()
        {
            return driver.FindElement(By.Name("q"));
        }

        public void enterValueJavascript(string str)
        {
            textAreaEle = getTextAreaEle();
            
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].value = arguments[1];", textAreaEle, str);
            textAreaEle.SendKeys(Keys.Enter);
            // Wait till page Load
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TitleContains("Search"));
        }

        public void clearValueAlternative()
        {
            textAreaEle = getTextAreaEle();
            textAreaEle.SendKeys("Clr");
            textAreaEle.Clear();
            textAreaEle.SendKeys("Clr-2");
            textAreaEle.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30); // Sets a 30-second timeout for page loads

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TitleContains("Search"));
            textAreaEle = getTextAreaEle();
            textAreaEle.SendKeys("");
        }
    }
}
