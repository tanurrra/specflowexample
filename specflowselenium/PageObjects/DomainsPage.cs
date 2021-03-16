using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace specflowselenium.PageObjects
{
    public class DomainsPage
    {
        public static Func1<string> linkByText = (string linkText) => By.XPath($"//a[contains(.,'{linkText}')]");
        public static Func3<string, int, string> linkByElementAndIndexAndText = (string elementText, int index, string text) => By.XPath(($"//h2[contains(., '{elementText}')]/parent::div//li[{index}]//a[contains(.,'{text}')]"));
    }
}
