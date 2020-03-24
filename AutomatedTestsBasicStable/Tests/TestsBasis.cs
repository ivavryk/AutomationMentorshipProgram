using AutomatedTestsBasicStable.Helper;
using OpenQA.Selenium;
using NUnit.Framework;

namespace AutomatedTestsBasic.Tests
{
    [TestFixture]
    class TestsBasis
    {
        public static IWebDriver _driver;

        public Pages.Pages Pages;

        [SetUp]
        public void SetUp()
        {
            _driver = ConfigurationHelper.Driver();

            Pages = new Pages.Pages(_driver);

            Pages.GoogleBasePage.OpenFullScreen();
        }

        [TearDown]
        public void TearDown()
        {
            Pages.GoogleBasePage.CloseBrowser();
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }
    }
}

