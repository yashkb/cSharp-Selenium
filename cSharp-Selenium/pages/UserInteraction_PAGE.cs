using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cSharp_Selenium.pages
{
    internal class UserInteraction_PAGE
    {
        private readonly IWebDriver driver;

        public UserInteraction_PAGE(IWebDriver driver) 
        { 
            this.driver = driver;
        }

        

        public void enterUserName()
        {
            IWebElement userName = driver.FindElement(By.Name("username"));
            userName.SendKeys("SachinTen");
        }
        public void enterPassword()
        {
            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("Sachin@123");
            
        }
        public void clickLoginBtn()
        {
            IWebElement loginBtn = driver.FindElement(By.XPath("//input[@value='Log In']"));
            loginBtn.Click();
        }

        public void rightClick()
        {
            IWebElement ele = driver.FindElement(By.XPath("//img[@title='ParaBank']"));
            Actions action = new Actions(driver);
            action.ContextClick(ele).Perform();
            
        }

        public void rightClickJS()
        {
            IWebElement ele = driver.FindElement(By.XPath("//img[@title='ParaBank']"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", ele);
        }

        public void SubmitForm()
        {
            IWebElement form = driver.FindElement(By.Id("login"));
            form.Submit();
        }
    }
}
