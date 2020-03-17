using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomatedTestsBasic.Tests
{
    class GoogleTests : TestsBasis
    {
        [SetUp]
        public void PreConditions()
        {
            BrowserToUse(Browser.Chrome);

            OpenFullScreen();
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

            Pages.GoogleSearchResultsPage.WaitPageToLoad();

            Assert.AreEqual(Pages.GoogleSearchResultsPage.RandomSearchTitle, Pages.GoogleSearchResultsPage.GetPageTitle());
        }

        [Test]
        public void BrowserNavigation()
        {
            Pages.GoogleInitialPage
                .Open()
                .ApplyRandomSearch();

            NavigateBackInBrowser();
            NavigateForwardInBrowser();
            NavigateBackInBrowser();
            RefreshPageInBrowser();

            Assert.AreEqual(Pages.GoogleInitialPage.Title, GetBrowserTitle(), $"Page title is incorrect.\nPage source: {GetPageSource()}");
            Assert.IsTrue(Pages.GoogleInitialPage.TxtSearch.Displayed && Pages.GoogleInitialPage.TxtSearch.Enabled);
            Assert.IsTrue(Pages.GoogleInitialPage.BtnSearch.Displayed && Pages.GoogleInitialPage.BtnSearch.Enabled);
            Assert.IsTrue(Pages.GoogleInitialPage.BtnRandomSearch.Displayed && Pages.GoogleInitialPage.BtnRandomSearch.Enabled);
        }

        [TearDown]
        public void PostConditions()
        {
            base.CloseBrowser();
        }
    }
}