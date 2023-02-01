using System;
using Allure.Commons;
using Automation_project.Helpers;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using SeleniumExtras.WaitHelpers;

namespace Automation_project.PageObjects
{
    [AllureNUnit()]
    public class SignUpPage : PageObject
    {
        private IWebDriver driver;
        public SignUpPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        private IWebElement firstName
        {
            get
            {
                FindElementHelper.TryGetElement(ExpectedConditions.ElementIsVisible(By.Name("userName")), By.Name("userName"), "username");
                var element = driver.FindElement(By.Name("userName"));

                return element;
            }
        } 
        private IWebElement lastName
        {
            get
            {
                FindElementHelper.TryGetElement(ExpectedConditions.ElementIsVisible(By.Name("password")), By.Name("password"), "password");
                return driver.FindElement(By.Name("password"));
            }
        }
        private IWebElement btn
        {
            get
            {
                FindElementHelper.TryGetElement(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='login__button']")), By.XPath("//button[@class='login__button']"), "submit button");
                return driver.FindElement(By.XPath("//button[@class='login__button']"));
            }
        }

        public SignUpPage EnterName(string firstName, string lastName)
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                var f_name = this.firstName;
                var l_name = this.lastName;

                f_name.Clear();
                f_name.SendKeys(firstName);

                l_name.Clear();
                l_name.SendKeys(lastName);
            }, $"Fill in first and last name: {firstName} {lastName}");

            return new SignUpPage(driver);
        }

        public HomePage Submit()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                btn.Click();
                try
                {
                    wait.Until(ExpectedConditions.UrlContains("/timeTable/viewWeek"));
                }
                catch (Exception e)
                {
                    AllureLifecycle.Instance.AddAttachment($"Screenshot [{DateTime.Now:HH:mm:ss}]", "image/png", driver.TakeScreenshot().AsByteArray);
                    AllureLifecycle.Instance.WrapInStep(() => Assert.Fail(), $"Cannot redirect to home page, {e}");
                }
                
            }, "Submit and log in");

            return new HomePage(driver);
        }
    }
}
