using NUnit.Framework;
using NUnit.Allure.Core;
using Allure.Commons;
using Automation_project.PageObjects;
using NUnit.Allure.Attributes;
using System;
using OpenQA.Selenium.Support.Extensions;

namespace Automation_project.Tests
{
    [TestFixture]
    [AllureNUnit()]
    public class SignUp : Global
    {
        [Test(Author = "Anastasiia Markina")]
        [Category("Test open browser")]
        [Description("Check that can log in")]
        [AllureTag("Nunit", "Debag")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void ShouldSignUp()
        {
            SignUpPage signUpPage = new SignUpPage(driver);
            signUpPage.EnterName("anastasia.markina@fastdev.se", "Iamsun1");

            signUpPage.Submit();
        }
    }
}
