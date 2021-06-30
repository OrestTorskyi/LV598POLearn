using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LV598POLearn.pages
{
    public class CurrentBestSellersProductPage : BaseCommon
    {
        #region Locators

        private IWebElement AddToCartButton { get { return Driver.FindElement(By.CssSelector("button.exclusive")); } }



        #endregion

        #region Components


        #endregion

        public CurrentBestSellersProductPage(IWebDriver driver) : base(driver)
        {

        }
        #region Methods

        public SuccesfullyAddedProductPage GetAddtoCartProducts()
        {
            Actions actions = new Actions(Driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            AddToCartButton.Click();
            Thread.Sleep(600);
            return new SuccesfullyAddedProductPage(Driver);





        }
        #endregion
    }
}
