using System;
using System.Collections.Generic;
using System.Text;
using Allure.Commons;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace Automation_project.Helpers
{
    [AllureNUnit()]
    public class FindElementHelper : Global
    {
        private static IWebDriver driver = Global.driver;
        private  static WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        public static void TryGetElement(Func<IWebDriver, IWebElement> expectedCondtions, By by, string fname)
        {
            try
            {
                wait.Until(expectedCondtions);
                try
                {
                    var element = driver.FindElement(by);
                    AllureLifecycle.Instance.WrapInStep(() => Assert.IsTrue(element.Displayed),
                        $"{fname} field is displayed");
                }
                catch (ElementNotVisibleException e)
                {
                    AllureLifecycle.Instance.WrapInStep(() => Assert.Fail(), $"The element {fname} is not found, {e}");
                }
            }
            catch (Exception e)
            {
                AllureLifecycle.Instance.WrapInStep(() => Assert.Fail(), $"The element {fname} is not found. There was the exception, {e}");
            }
        }
    }
}
