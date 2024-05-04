using cSharp_Selenium.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Selenium.pages.Mouse_and_Keyboard
{
    internal class Mouse_Operations_PAGE
    {
        IWebDriver driver;
        public Mouse_Operations_PAGE(IWebDriver driver)
        {
            this.driver = driver;
            TestLogger.LogInfo("Driver Mouse Init");
        }

        public void hoverAction()
        {
            IList<IWebElement> figure = driver.FindElements(By.ClassName("figure"));
            Actions action = new Actions(driver);
            foreach (IWebElement element in figure)
            {
                action.MoveToElement(element).Perform();
            }
        }

        public void hoverActionPractice()
        {
            IList<IWebElement> profile = driver.FindElements(By.ClassName("figure"));
            Actions action = new Actions(driver);
            foreach (var item in profile)
            {
                action.MoveToElement(item).Perform();
                var viewProfileLink = driver.FindElement(By.PartialLinkText("View profile"));
                action.Click(viewProfileLink).Perform();
            }
        }

        public void hoverActionPracticeWithReport()
        {
            IList<IWebElement> profile = driver.FindElements(By.ClassName("#fig"));
            Actions action = new Actions(driver);
            foreach (var item in profile)
            {
                action.MoveToElement(item).Perform();
            }

        }

    }
}
