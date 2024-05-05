using cSharp_Selenium.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Selenium.pages.Advance_Features
{
    internal class Handle_Alerts_PAGE
    {
        IWebDriver driver;
        public Handle_Alerts_PAGE(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickAlertOK()
        {
            IWebElement alertBtn = driver.FindElement(By.CssSelector(".btn.btn-danger"));
            alertBtn.Click();
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

        }
        public void ClickAlertCancel()
        {
            IWebElement alertCancel_LI = driver.FindElement(By.CssSelector(".analystic[href='#CancelTab']"));
            alertCancel_LI.Click();
            IWebElement alertCancelBtn = driver.FindElement(By.CssSelector(".btn.btn-primary"));
            alertCancelBtn.Click();
            driver.SwitchTo().Alert().Dismiss();
        }

        public void ClickAlertTxtBox()
        {
            IWebElement alertTxtBox_LI = driver.FindElement(By.CssSelector(".analystic[href='#Textbox']"));
            alertTxtBox_LI.Click();
            IWebElement alertTxtBoxBtn = driver.FindElement(By.CssSelector(".btn.btn-info"));
            alertTxtBoxBtn.Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.SendKeys("Yash");
            alert.Accept();
            Thread.Sleep(2000);
        }
    }
}
