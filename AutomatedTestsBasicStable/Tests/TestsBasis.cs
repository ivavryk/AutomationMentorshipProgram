using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using NUnit.Framework;

namespace AutomatedTestsBasic.Tests
{
    class TestsBasis
    {
        public static IWebDriver _driver;

        public Pages.Pages Pages = new Pages.Pages(_driver);

        [SetUp]
        public void PreConditions()
        {
            BrowserToUse(Browser.Chrome);

            Pages.GoogleBasePage.OpenFullScreen();
        }

        [TearDown]
        public void PostConditions()
        {
            Pages.GoogleBasePage.CloseBrowser();
        }


        // TODO: Move to app config file.
        public void BrowserToUse(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    _driver = new ChromeDriver();
                    break;
                case Browser.Firefox:
                    _driver = new FirefoxDriver();
                    break;
                case Browser.Edge:
                    _driver = new EdgeDriver();
                    break;
                default:
                    _driver = new ChromeDriver();
                    break;
            }
        }

        public enum Browser
        {
            Chrome,
            Firefox,
            Edge
        }
    }
}

