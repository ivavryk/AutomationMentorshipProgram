using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

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
    }
}
