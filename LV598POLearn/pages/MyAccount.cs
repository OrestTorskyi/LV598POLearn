using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LV598POLearn.pages
{
    public class MyAccount : BaseCommon
    {
        private IWebElement buttonMyWishlist { get { return Driver.FindElement(By.CssSelector("a[title='My wishlists']")); } }
       
       public MyAccount(IWebDriver driver) : base(driver) { }

        public WishListComponent goToWishListComponent()
        {
            buttonMyWishlist.Click();
            return new WishListComponent(Driver);
        }
    }
    
}
