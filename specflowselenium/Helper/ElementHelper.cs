﻿using NLog.Fluent;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace specflowselenium.Helper
{
    internal class ElementHelper
    {
        public static bool IsElementClickable(IWebElement element)
        {
            try
            {
                return (element.Displayed && element.Enabled);

            }
            catch (NoSuchElementException Ex)
            {
                Log.Info($"Cannot find element {element}. Error: " + Ex);
                return false;
            }
        }

        public static IWebElement WaitUntilElementIsVisible(IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                try
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                    return wait.Until(drv => drv.FindElement(by));
                }
                catch (NoSuchElementException Ex)
                {
                    Log.Info($"Cannot find element {by}. Error: " + Ex);
                    return null;
                }
            }
            return driver.FindElement(by);
        }
    }
}
