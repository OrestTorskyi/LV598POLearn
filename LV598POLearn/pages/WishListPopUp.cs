using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LV598POLearn.pages
{
    public class WishListPopUp : BasePopup
    {
        public WishListPopUp(IWebDriver driver) : base(driver) { }
        #region Locators
        private IWebElement buttonCloseMessage { get { return Driver.FindElement(By.CssSelector("a[title='Close']")); } }
        #endregion
        #region Methods
        public ProductItemPage closePopUp()
        {
            buttonCloseMessage.Click();
            return new ProductItemPage(Driver);
        }
        #endregion
    }
}
