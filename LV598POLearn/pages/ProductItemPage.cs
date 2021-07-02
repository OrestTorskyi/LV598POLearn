using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LV598POLearn.pages
{
    public class ProductItemPage : BasePage
    {
        public ProductItemPage(IWebDriver driver) : base(driver) { }
        #region Locators
        private IWebElement buttonAddToWishList { get { return Driver.FindElement(By.Id("wishlist_button")); } }
        private IWebElement buttonMyAccount;
        #endregion
        #region Methods
        public WishListPopUp addToWishList()
        {
            Driver.Manage().Window.Maximize();
            buttonAddToWishList.Click();
            return new WishListPopUp(Driver);
        }
        public MyAccount goToMyAccount()
        {
            buttonMyAccount = Driver.FindElement(By.CssSelector(".account"));
            buttonMyAccount.Click();
            return new MyAccount(Driver);
        }
        #endregion

    }
}
