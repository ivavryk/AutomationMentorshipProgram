using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomatedTestsBasic.Pages
{
    public class GoogleInitialPage : GoogleBasePage
    {
     /// <summary>
     /// Google initial page constructor.
     /// </summary>
     /// <param name="driver"></param>
        public GoogleInitialPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private readonly IWebDriver _driver;

        public string Url = "https://www.google.com";
        public string Title = "Google";

        //private readonly By _txtSearchBy = By.XPath("//div[2]/input");
        //private readonly By _btnSearchBy = By.XPath("//div[3]/center/input[1]");
        //private readonly By _btnRandomSearch = By.XPath("//div[3]/center/input[2]");
        //public IWebElement TxtSearch => _driver.FindElement(_txtSearchBy);
        //public IWebElement BtnSearch => _driver.FindElement(_btnSearchBy);
        //public IWebElement BtnRandomSearch => _driver.FindElement(_btnRandomSearch);

        public IWebElement TxtSearch => _driver.FindElement(By.Name("q"));
        public IWebElement BtnSearch => _driver.FindElement(By.CssSelector("center:nth-child(1) > input[name='btnK']:nth-child(1)"));
        public IWebElement BtnRandomSearch => _driver.FindElement(By.CssSelector("center:nth-child(1) > input[name='btnI']:nth-child(2)"));

        /// <summary>
        /// Opens initial Google search page.
        /// </summary>
        public GoogleInitialPage Open()
        {
            _driver.Navigate().GoToUrl(Url);

            return this;
        }

        /// <summary>
        /// Applies search of the word.
        /// </summary>
        /// <param name="searchWord"></param>
        public void ApplySearch(string searchWord)
        {
            TxtSearch.SendKeys(searchWord);
            BtnSearch.Click();
        }

        /// <summary>
        /// Applies random search.
        /// </summary>
        public void ApplyRandomSearch()
        {
            BtnRandomSearch.Click();
        }
    }
}
