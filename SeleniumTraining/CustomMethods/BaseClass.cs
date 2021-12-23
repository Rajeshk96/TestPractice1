using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTraining.CustomMethods
{
    internal class BaseClass
    {
        public static IWebDriver MyDriver { get; private set; }

        public static void EnterText(IWebElement element, string value)
        {
            element.Click();
            element.Clear();
            element.SendKeys(value);
        }

        public static void SelectFromDropDownByText(IWebElement element, string inputText)
        {
            //new SelectElement(element).SelectByText(inputValue);
            SelectElement se = new SelectElement(element);
            se.SelectByText(inputText);
        }

        public static void SelectFromDropDownByValue(IWebElement element, string inputValue)
        {
            //new SelectElement(element).SelectByText(inputValue);
            SelectElement se = new SelectElement(element);
            se.SelectByText(inputValue);
        }

        public static void ActionClick(IWebElement Element)
        {
            Actions action = new Actions(MyDriver);
            action.MoveToElement(Element).Build().Perform();
        }


    }
}
