﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LV598POLearn.pages
{
   public class WishListComponent : BaseCommon
    {
        public WishListComponent(IWebDriver driver) : base(driver) { }
        #region Locators
        private IWebElement wishListName { get { return Driver.FindElement(By.XPath("//a[contains(text(),'My wishlist')]"));} }
        #endregion
        #region Methods
        public String getWishListName()
        {
          return  wishListName.Text;
        }
        #endregion
    }
}
