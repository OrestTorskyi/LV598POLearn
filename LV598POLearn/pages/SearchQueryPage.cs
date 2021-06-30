using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV598POLearn.pages
{
    public class SearchQueryPage : BaseCommon
    {
        #region Locators
        private IWebElement GridViewBtn { get { return Driver.FindElement(By.XPath("//li[@id = 'grid']/a")); } }
        private IWebElement ListViewBtn { get { return Driver.FindElement(By.XPath("//li[@id = 'list']/a")); } }
        #endregion
        public SearchQueryPage(IWebDriver driver) : base(driver) { }


        #region Methods
        public SearchQueryPage clickOnGridViewButton()
        {
            GridViewBtn.Click();
            return this;
        }

        public SearchQueryPage clickOnListViewButton()
        {
            ListViewBtn.Click();
            return this;
        }
        #endregion
    }
}
