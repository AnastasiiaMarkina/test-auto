using System;
using Allure.Commons;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace Automation_project
{
    public class Global
    {
        protected static IWebDriver driver;

        [SetUp]
        public static void CleanUpDirectoryAndStartBrowser()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://app.fastpool.net/login.htm");
            AllureLifecycle.Instance.AddAttachment($"Screenshot [{DateTime.Now:HH:mm:ss}]", "image/png", driver.TakeScreenshot().AsByteArray);
        }

        [TearDown]
        public void cleanUp()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Close();
        }

        //[OneTimeTearDown]
        //public static void close_Browser()
        //{
        //    driver.Close();
        //}
    }
}
