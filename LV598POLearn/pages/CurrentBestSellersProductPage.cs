using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LV598POLearn.utils;
using OpenQA.Selenium.Support.UI;

namespace LV598POLearn.pages
{
    public class CurrentBestSellersProductPage : BaseCommon
    {
        public CurrentBestSellersProductPage(IWebDriver driver) : base(driver) { }
        #region Locators
        private IWebElement AddToCartButton { get { return Driver.FindElement(By.CssSelector("button.exclusive")); } }

        #endregion
        #region Components

        #endregion

        #region Methods

        public SuccesfullyAddedProductPage GetAddtoCartProducts()
        {
            Actions actions = new Actions(Driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            AddToCartButton.Click();
            WaitSwitcher.SetExcplicitlyWait(Driver, 10, ExpectedConditions.ElementToBeClickable(AddToCartButton));
            return new SuccesfullyAddedProductPage(Driver);
        }
        #endregion
    }
}
