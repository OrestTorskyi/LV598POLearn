using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LV598POLearn.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LV598POLearn.pages
{
    public class MainPage : BaseCommon
    {
        public MainPage(IWebDriver driver) : base(driver) { }
       
        #region Locators
        private IWebElement productItem { get { return Driver.FindElement(By.CssSelector("#homefeatured li:first-child a[class='product_img_link']")); } }
        #endregion

                #region Components
                #endregion
                
        #region Methods
        public ProductItemPage chooseFirstProductItem()
        {
            Driver.Manage().Window.Size = new System.Drawing.Size(1024, 656);
            productItem.Click();
            return new ProductItemPage(Driver);
        }
      
        #endregion
    }
}
