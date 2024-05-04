using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Selenium.pages
{
    internal class Window_PAGE
    {
        IWebDriver driver;
        
        IWebElement ele;

        public Window_PAGE(IWebDriver driver) 
        {
            this.driver = driver;
        }
        
        public void openWindow()
        {
            driver.SwitchTo().NewWindow(WindowType.Tab);
            driver.SwitchTo().NewWindow(WindowType.Tab);
        }

    }
}
