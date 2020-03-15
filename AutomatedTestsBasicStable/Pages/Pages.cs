using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomatedTestsBasic.Pages
{
    public class Pages
    {
        public Pages(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly IWebDriver _driver;

        private GoogleInitialPage _googleInitialPage;
        private GoogleSearchResultsPage _googleSearchResultsPage;

        public GoogleInitialPage GoogleInitialPage => 
            _googleInitialPage ??= new GoogleInitialPage(_driver);

        public GoogleSearchResultsPage GoogleSearchResultsPage =>
            _googleSearchResultsPage ??= new GoogleSearchResultsPage(_driver);
    }
}
