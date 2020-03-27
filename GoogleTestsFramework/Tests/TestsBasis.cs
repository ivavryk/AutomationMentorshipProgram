using AutomatedTestsBasicStable.Helper;
using OpenQA.Selenium;
using NUnit.Framework;

namespace AutomatedTestsBasic.Tests
{
    [TestFixture]
    class TestsBasis
    {
        public static IWebDriver Driver = ConfigurationHelper.Driver();

        public Pages.Pages Pages;

        [SetUp]
        public void SetUp()
        {
            Pages = new Pages.Pages();

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

