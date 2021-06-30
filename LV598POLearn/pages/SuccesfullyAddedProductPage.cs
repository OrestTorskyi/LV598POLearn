﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV598POLearn.pages
{
    public class SuccesfullyAddedProductPage : BasePopup
    {
        #region Locators

        private IWebElement ProceedToCheckoutButton { get { return Driver.FindElement(By.XPath("//a[@title='Proceed to checkout']")); } }
        #endregion
        public SuccesfullyAddedProductPage(IWebDriver driver) : base(driver)
        {

        }

        #region Methods
        public CartPage ProceedToChecckout()
        {
            ProceedToCheckoutButton.Click();
            return new CartPage(Driver);
        }
        #endregion

    }
}
