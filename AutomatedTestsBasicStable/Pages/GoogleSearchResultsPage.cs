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
            _driver = Tests.TestsBasis._driver;
        }

        private readonly IWebDriver _driver;

        public string SpecificSearchTitle = " - Пошук Google";
        public string RandomSearchTitle = "Google Doodles";

        public IWebElement SearchResults => _driver.FindElement(By.Id("res"));

        /// <summary>
        /// Wait page to load.
        /// </summary>
        public void WaitPageToLoad()
        {
            WaitPageToLoad(By.Id("content-wrap"));
        }
    }
}
