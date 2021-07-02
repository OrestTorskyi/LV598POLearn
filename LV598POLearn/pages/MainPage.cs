using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LV598POLearn.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace LV598POLearn.pages
{
    public class MainPage : BaseCommon
    {
        public MainPage(IWebDriver driver) : base(driver) { }

        #region Locators
        private IWebElement BestSellersButton { get { return Driver.FindElement(By.XPath("//a[@class='blockbestsellers']")); } }
        private IWebElement CurrentProductButton { get { return Driver.FindElement(By.XPath("//*[@id='blockbestsellers']/li/div/div[@class='right-block']/h5/a[contains(text(),'Printed Chiffon Dress')]")); } }
        private IWebElement productItem { get { return Driver.FindElement(By.CssSelector("#homefeatured li:first-child a[class='product_img_link']")); } }
        #endregion
        #region Components
        #endregion
        #region Methods
        public MainPage ChooseBestSellersProducts()
        {
            Actions actions = new Actions(Driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            BestSellersButton.Click();
            return this;
        }
        public CurrentBestSellersProductPage GetBestSellerProduct()
        {
            CurrentProductButton.Click();
            Thread.Sleep(400);
            return new CurrentBestSellersProductPage(Driver);
        }
        public ProductItemPage chooseFirstProductItem()
        {
            Driver.Manage().Window.Size = new System.Drawing.Size(1024, 656);
            productItem.Click();
            return new ProductItemPage(Driver);
        }
        #endregion
    }

}

