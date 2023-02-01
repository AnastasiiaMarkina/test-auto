using NUnit.Allure.Core;
using OpenQA.Selenium;
using Automation_project.Helpers;
using Allure.Commons;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;

namespace Automation_project.PageObjects
{
    [AllureNUnit()]
    public class HomePage : PageObject
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        private IWebElement header
        {
            get
            {
                FindElementHelper.TryGetElement(ExpectedConditions.ElementExists(By.XPath("/html/head/title")), By.XPath("/html/head/title"), "home page title");
                return driver.FindElement(By.XPath("/html/head/title"));
            }
        }
        public string ConfirmationHeader()
        {
            var title = header.GetAttribute("textContent");
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                Assert.IsTrue(title.Equals("Fastpool - logged on"));
            }, "Check that correct page is shown");

            return title;
        }
    }
}
