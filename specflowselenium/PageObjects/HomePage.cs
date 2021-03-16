using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace specflowselenium.PageObjects
{
    public class HomePage
    {
        public static Func1<string> linkByText = (string linkText) => By.XPath($"//a[contains(.,'{linkText}')]");
    }
}
