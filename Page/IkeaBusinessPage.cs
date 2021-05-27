using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCStest.Page
{
    public class IkeaBusinessPage : BasePage
    {
        private const string addressUrl = "https://www.ikea.lt/lt/rooms/ikea-verslui/biuras";
        private IWebElement selectProduct => Driver.FindElement(By.CssSelector("#categories > div > div:nth-child(1) > a"));
        private IWebElement okCookieButton => Driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAccept"));

        private IWebElement buttonColor => Driver.FindElement(By.CssSelector("#colorFilter"));

        private IWebElement buttonColorSelect => Driver.FindElement(By.CssSelector("#filterSelectors > div > div > nav > div > div.filterContainerMultiple > div:nth-child(3) > ul > li:nth-child(1) > span.icheck.icheck_minimal > div > ins"));

        private IWebElement buttonDeselect => Driver.FindElement(By.CssSelector("#filterList > div > div:nth-child(3) > div > div > div > div > a"));

        private IWebElement buttonPageSelect => Driver.FindElement(By.CssSelector("#contentWrapper > div > div > div:nth-child(1) > div > div > div > div.col-auto.mt-3.mx-auto.mx-lg-0.my-lg-auto > nav > ul > li.page-item.active > a"));

        private IWebElement resultElement => Driver.FindElement(By.CssSelector("#contentWrapper > div > div > div:nth-child(1) > div > div > div > div.col-6.col-sm-4.col-lg-auto.mr-lg-4.my-auto > h5"));

        public IkeaBusinessPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            Driver.Url = addressUrl;
        }

        public void CloseCookie()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(_driver => _driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAccept")).Displayed);
            okCookieButton.Click();
        }

        public void ClickProduct()
        {
            selectProduct.Click();
        }

        public void ClickColor()
        {
            buttonColor.Click();
        }

        public void ClickConcreteColor()
        {
            buttonColorSelect.Click();
        }

        public void ClickDeselect()
        {
            buttonDeselect.Click();
        }

        public void ClickPage()
        {
            buttonPageSelect.Click();
        }

        public void CheckResult(string result)
        {
            Assert.IsTrue(resultElement.Text.Contains(result), $"Result is not correct, expected {result}, but was {resultElement.Text}");
        }
    }
}