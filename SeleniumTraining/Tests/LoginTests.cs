using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTraining.Tests
{
    internal class LoginTests
    {
        [OneTimeSetUp]
        public void Setup()
        {
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://phptravels.net/api/admin");
            driver.FindElement(By.Name("email")).SendKeys("admin@phptravels.com");
            driver.FindElement(By.Name("password")).SendKeys("demoadmin");
            driver.FindElement(By.XPath("//span[text()='Login']")).Click();
        }

        [Test]
        public void Login()
        {
            Assert.Pass();
        }

    }
}
