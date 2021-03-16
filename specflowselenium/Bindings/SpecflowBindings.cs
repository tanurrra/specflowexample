namespace specflowselenium.Bindings
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NLog.Fluent;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.UI;
    using specflowselenium.Helper;
    using System;
    using TechTalk.SpecFlow;

    [Binding]
    internal class SpecflowBindings
    {
        private IWebDriver Driver;

        [When(@"I start the browser")]
        public void WhenIStartTheBrowser()
        {
            var options = new FirefoxOptions
            {
                // put path to firefox.exe here
                BrowserExecutableLocation = "C:\\Users\\tvelik\\AppData\\Local\\Mozilla Firefox\\firefox.exe"
            };
            Driver = new FirefoxDriver(options);
        }

        [When(@"I navigate to '(.*)'")]
        public void WhenINavigateToHttpExample_Com(string Url)
        {
            Driver.Navigate().GoToUrl(Url);
        }

        [When(@"I click on the '(.*)'")]
        public void WhenIClickOnThe(string buttonname)
        {
            const string button = "//a[contains(@href, 'example')]";
            // TODO move to page objects
            OpenQA.Selenium.IWebElement element = Driver.FindElement(By.XPath(button));
            const int DefaultTimeoutInSec = 5;
            ElementHelper.WaitUntilElementIsVisible(Driver, By.XPath(button), DefaultTimeoutInSec);
            element.Click();
        }
        [Then(@"a link with text '(.*)' must be present")]
        public void ThenALinkWithTextMustBePresent(string linkText)
        {
            var bylink = By.XPath($"//a[contains(.,'{linkText}')]");
            OpenQA.Selenium.IWebElement element = Driver.FindElement(bylink);
            var isVisible = ElementHelper.IsElementClickable(element);
            Assert.IsTrue(isVisible, $"Element {linkText} is not visible");
        }

        [Then(@"the '(.*)' box must contain '(.*)' at index '(.*)'")]
        public void ThenTheBoxMustContainAtIndex(string elementText, string text, int index)
        {
            var bylink = By.XPath($"//h2[contains(., '{elementText}')]/parent::div//li[{index}]//a[contains(.,'{text}')]");
            OpenQA.Selenium.IWebElement element = ElementHelper.WaitUntilElementIsVisible(Driver, bylink, 5);
            var isVisible = ElementHelper.IsElementClickable(element);
            Assert.IsTrue(isVisible, $"Element {elementText} with index {index} does not contain text {text}");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Close();
        }
    }
}
