using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTraining
{
    public class TestsSample
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://github.com/");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}