using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using LV598POLearn.pages.searchquery;

namespace LV598POLearn.pages
{
    class MainPage : BaseCommon
    {

        #region Locators
        private IWebElement InputSearchField { get { return Driver.FindElement(By.Id("search_query_top")); } }
        private IWebElement SubmitSearchQueryBtn { get { return Driver.FindElement(By.XPath("//button[@name = 'submit_search']")); } }
        #endregion

        #region Components
        SearchQueryComponent searchQueryComponent;
        #endregion

        public MainPage(IWebDriver driver) : base(driver) { }
        
        #region Methods
        public MainPage SearchSomeProducts(string text)
        {
            InputSearchField.Clear();
            InputSearchField.SendKeys(text);
            SubmitSearchQueryBtn.Click();
            searchQueryComponent = new SearchQueryComponent(Driver);
            return this;
        }

        public void ClickOnListViewBtn()
        {
            searchQueryComponent.clickOnListViewButton();
        }

        #endregion
    }
}
