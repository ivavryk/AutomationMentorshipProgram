using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace AutomatedTestsBasic.Tests
{
    class TestsBasis
    {
        static IWebDriver _driver = new ChromeDriver();

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

        public Pages.Pages Pages = new Pages.Pages(_driver);


        public string GetBrowserTitle()
        {
            return _driver.Title;
        }

        public string GetPageSource()
        {
            return _driver.PageSource;
        }

        public void OpenFullScreen()
        {
            _driver.Manage().Window.FullScreen();
        }

        public void CloseBrowser()
        {
            _driver.Quit();
        }

        public void NavigateBackInBrowser()
        {
            _driver.Navigate().Back();
        }

        public void NavigateForwardInBrowser()
        {
            _driver.Navigate().Forward();
        }

        public void RefreshPageInBrowser()
        {
            _driver.Navigate().Refresh();
        }
    }
}
