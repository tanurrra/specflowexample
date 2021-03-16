﻿namespace specflowselenium.Bindings
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NLog.Fluent;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.UI;
    using specflowselenium.Helper;
    using specflowselenium.PageObjects;
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
                BrowserExecutableLocation = "C:\\Mozilla Firefox\\firefox.exe"
            };
            Driver = new FirefoxDriver(options);
        }

        [When(@"I navigate to '(.*)'")]
        public void WhenINavigateToHttpExample_Com(string Url)
        {
            Driver.Navigate().GoToUrl(Url);
        }

        [When(@"I click on the link with text '(.*)'")]
        public void WhenIClickOnThe(string linkText)
        {
            OpenQA.Selenium.IWebElement element = ElementHelper.WaitUntilElementIsVisible(Driver, HomePage.linkByText(linkText), 5);
            element.Click();
        }

        [Then(@"a link with text '(.*)' must be present")]
        public void ThenALinkWithTextMustBePresent(string linkText)
        {
            OpenQA.Selenium.IWebElement element = Driver.FindElement(DomainsPage.linkByText(linkText));
            var isVisible = ElementHelper.IsElementClickable(element);
            Assert.IsTrue(isVisible, $"Link with text '{linkText}' is not visible");
        }

        [Then(@"the '(.*)' box must contain '(.*)' at index '(.*)'")]
        public void ThenTheBoxMustContainAtIndex(string elementText, string text, int index)
        {
            OpenQA.Selenium.IWebElement element = ElementHelper.WaitUntilElementIsVisible(Driver, DomainsPage.linkByElementAndIndexAndText(elementText, index, text), 5);
            var isVisibleAndClickable = ElementHelper.IsElementClickable(element);
            Assert.IsTrue(isVisibleAndClickable, $"Element {elementText} with index {index} does not contain text {text}");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Close();
        }
    }
}
