using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV598POLearn.pages.searchquery
{
    class SearchQueryComponent : BaseCommon
    {
        public SearchQueryComponent(IWebDriver driver) : base(driver) { }

        #region Locators
        private IWebElement GridViewBtn { get { return Driver.FindElement(By.XPath("//li[@id = 'grid']/a")); } }
        private IWebElement ListViewBtn { get { return Driver.FindElement(By.XPath("//li[@id = 'list']/a"));  } }
        #endregion


        #region Methods
        public void clickOnGridViewButton()
        {
            GridViewBtn.Click();
        }

        public void clickOnListViewButton()
        {
            ListViewBtn.Click();
        }
        #endregion
    }
}
