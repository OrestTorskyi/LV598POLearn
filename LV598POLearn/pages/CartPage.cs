using LV598POLearn.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV598POLearn.pages
{
    public class CartPage : BaseCommon
    {
        public CartPage(IWebDriver driver) : base(driver) { }
        #region Locators
        private IWebElement DeleteButton { get { return Driver.FindElement(By.XPath("//a[@title='Delete']")); } }
        private IWebElement WarningMessage { get { return Driver.FindElement(By.CssSelector("#center_column > p")); } }

        #endregion

        #region Components
        #endregion

        #region Methods

        public void DeleteProduct()
        {
            DeleteButton.Click();
        }
        public string GetTextWarningMessage()
        {
            WaitSwitcher.SetExcplicitlyWait(Driver, 10, ExpectedConditions.ElementIsVisible(By.CssSelector("#center_column > p")));
            return WarningMessage.Text;
        }
        #endregion
    }
}
