using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace AutomatedTestsBasic.Tests
{
    // This is used only for trainig purposes, so it contains a lot of incorrect approaches.
    [TestFixture]
    class ControlsTests
    {
        private IWebDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.FullScreen();
        }

        [Test]
        public void DropDownCheck()
        {
            _driver.Url = "https://www.facebook.com/";

            IWebElement MonthDropDown = _driver.FindElement(By.Id("month"));
            SelectElement SelectMonthDropDown = new SelectElement(MonthDropDown);
            SelectMonthDropDown.SelectByText("Apr");

            Assert.AreEqual("4", MonthDropDown.GetAttribute("value"));
        }

        [Test]
        public void Hint()
        {
            _driver.Url = "https://www.facebook.com/";

            IWebElement BirthDayHintButton = _driver.FindElement(By.Id("//*[@id=\"birthday - help\"]/i"));
            IWebElement BDHint = _driver.FindElement(By.Id("//*[@id=\"globalContainer\"]/div[3]/div"));

            BirthDayHintButton.Click();

            Assert.IsTrue(_driver.SwitchTo().ActiveElement()
                .FindElement(By.XPath("//*[@id=\"globalContainer\"]/div[3]/div")).Text.Contains("Providing your birthday"));

            _driver.SwitchTo().ActiveElement()
                .FindElement(By.XPath("//*[@id=\"globalContainer\"]/div[3]/div/div/div/div[2]/a")).Click();
        }

        [TestCase]
        [MaxTime(90000)]

        public void Popup()
        {
            _driver.Url = "https://www.seleniumeasy.com/test/bootstrap-modal-demo.html";

            _driver.FindElement(By.XPath(
                    "/html/body/div[2]/div/div[2]/div[1]/div/div/div[2]/a"))
                .Click();

            Thread.Sleep(2000);

            Assert.IsTrue(_driver.SwitchTo().DefaultContent().SwitchTo().ActiveElement().Text
                .Contains("This is the place where the content for the modal dialog displays"));

            _driver.SwitchTo().DefaultContent().SwitchTo().ActiveElement().FindElement(By.ClassName("btn")).Click();
        }

        [Test]
        public void Alert()
        {
            _driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/javascript-alert-box-demo.html");
            _driver.FindElement(By.CssSelector("div.panel:nth-child(4) > div:nth-child(2) > button:nth-child(4)"))
                .Click();
            Assert.IsTrue(_driver.SwitchTo().Alert().Text.Equals("I am an alert box!"));
            _driver.SwitchTo().Alert().Accept();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
