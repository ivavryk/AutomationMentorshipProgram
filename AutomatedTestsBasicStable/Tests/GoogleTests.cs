using System;
using System.Threading;
using AutomatedTestsBasic.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomatedTestsBasic.Tests
{
    [TestFixture]
    class GoogleTests
    {
        static IWebDriver _driver;

        Pages.Pages Pages;
        
        [SetUp]
        public void StartBrowser()
        {
            _driver = new ChromeDriver();

            _driver.Manage().Window.FullScreen();

            Pages = new Pages.Pages(_driver);
        }

        [Test]
        public void SearchWord()
        {
            const string searchWord = "Webdriver";

            Pages.GoogleInitialPage.Open();
            
            Assert.AreEqual(Pages.GoogleInitialPage.Title, Pages.GoogleInitialPage.GetPageTitle());

            Pages.GoogleInitialPage.ApplySearch(searchWord);

            Assert.AreEqual(searchWord + Pages.GoogleSearchResultsPage.SpecificSearchTitle, Pages.GoogleInitialPage.GetPageTitle());
            Assert.IsTrue(Pages.GoogleSearchResultsPage.SearchResults.Text.Contains(searchWord));
        }

        [Test]
        public void RandomSearch()
        {
            Pages.GoogleInitialPage
                .Open()
                .ApplyRandomSearch();

            // TODO: change to a correct waiter.
            Thread.Sleep(2000);

            Assert.AreEqual(Pages.GoogleSearchResultsPage.RandomSearchTitle, Pages.GoogleSearchResultsPage.GetPageTitle());
        }

        [Test]
        public void BrowserNavigation()
        {
            Pages.GoogleInitialPage
                .Open()
                .ApplyRandomSearch();

            _driver.Navigate().Back();
            _driver.Navigate().Forward();
            _driver.Navigate().Back();
            _driver.Navigate().Refresh();

            Assert.AreEqual(Pages.GoogleInitialPage.Title, _driver.Title, $"Page title is incorrect.\nPage source: {_driver.PageSource}");
            Assert.IsTrue(Pages.GoogleInitialPage.TxtSearch.Displayed && Pages.GoogleInitialPage.TxtSearch.Enabled);
            Assert.IsTrue(Pages.GoogleInitialPage.BtnSearch.Displayed && Pages.GoogleInitialPage.BtnSearch.Enabled);
            Assert.IsTrue(Pages.GoogleInitialPage.BtnRandomSearch.Displayed && Pages.GoogleInitialPage.BtnRandomSearch.Enabled);
        }

        [TearDown]
        public void CloseBrowser()
        {
            _driver.Quit();
        }
    }
}