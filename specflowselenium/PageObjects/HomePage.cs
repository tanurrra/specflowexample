using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace specflowselenium.PageObjects
{
    public class HomePage
    {
        private IWebDriver _webDriver;

        public HomePage(IWebDriver driver)
        {
            _webDriver = driver;
        }

        public static By linkMoreInfoBy = By.XPath("//a[contains(@href, 'example')]");
    
    }
}
