using cSharp_Selenium.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Selenium.pages.Work_with_Data
{
    internal class FileUpload_PAGE 
    {
        string fileUploadURL = "https://the-internet.herokuapp.com/upload";
        IWebDriver driver;
        public FileUpload_PAGE(IWebDriver driver) 
        {
            this.driver = driver;
            driver.Url = fileUploadURL;
        }

        public void getChooseFileBtn()
        {
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TitleContains("Internet"));
            IWebElement fileInput = driver.FindElement(By.Id("file-upload"));
            string filePath = @"C:\Users\ADMIN\Downloads\sampleFileUpload.txt";
            fileInput.SendKeys(filePath);
            var uploadButton = driver.FindElement(By.Id("file-submit"));
            uploadButton.Click();
            var successMessage = driver.FindElement(By.CssSelector(".example h3")).Text;
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".example h3")));
            if (successMessage == "File Uploaded!")
            {
                Console.WriteLine("File uploaded successfully.");
            }
            else
            {
                Console.WriteLine("File upload failed.");
            }

        }

    }
}
