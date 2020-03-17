using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomatedTestsBasic.Pages
{
    public class GoogleBasePage
    {
        /// <summary>
        /// Google base page constructor.
        /// </summary>
        /// <param name="driver"></param>
        protected GoogleBasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly IWebDriver _driver;

        /// <summary>
        /// Gets current page's title.
        /// </summary>
        /// <returns></returns>
        public string GetPageTitle()
        {
            return _driver.Title;
        }

        /// <summary>
        /// Wait page to load.
        /// </summary>
        /// <param name="by"></param>
        public void WaitPageToLoad(By by)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => _driver.FindElements(by).Count > 0);
        }
    }
}
