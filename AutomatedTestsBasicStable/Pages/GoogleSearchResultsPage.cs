using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomatedTestsBasic.Pages
{
    public class GoogleSearchResultsPage : GoogleBasePage
    {
        /// <summary>
        /// Google search results page constructor.
        /// </summary>
        /// <param name="driver"></param>
        public GoogleSearchResultsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private readonly IWebDriver _driver;

        public string SpecificSearchTitle = " - Пошук Google";
        public string RandomSearchTitle = "Google Doodles";


        private readonly By _sectionSearchResultsBy = By.Id("res");

        public IWebElement SearchResults => _driver.FindElement(_sectionSearchResultsBy);
    }
}
