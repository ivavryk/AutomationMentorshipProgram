using AutomatedTestsBasicStable.Helper;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AutomatedTestsBasic.Tests
{
    [TestFixture]
    class TestsBasis
    {
        private static IWebDriver _webDriver;
        public static IWebDriver WebDriver
        {
            get { return _webDriver ??= ConfigurationHelper.Driver(); }
        }

        public static IWebDriver Driver = WebDriver;

        //public IWebDriver Driver;

        public Pages.Pages Pages;

        [SetUp]
        public void SetUp()
        {
            //Driver = new ChromeDriver();
            
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

