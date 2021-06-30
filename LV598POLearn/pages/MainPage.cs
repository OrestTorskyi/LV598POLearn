using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace LV598POLearn.pages
{
    public class MainPage : BaseCommon
    {

        #region Locators

        private IWebElement ButtonSignIn { get { return Driver.FindElement(By.CssSelector(".login")); } }
        private IWebElement BestSellersButton { get { return Driver.FindElement(By.XPath("//a[@class='blockbestsellers']")); } }
        private IWebElement CurrentProductButton { get { return Driver.FindElement(By.XPath("//*[@id='blockbestsellers']/li/div/div[@class='right-block']/h5/a[contains(text(),'Printed Chiffon Dress')]")); } }


        #endregion

        #region Components
        #endregion


        public MainPage(IWebDriver driver) : base(driver)
        {
        }


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


    }
    #endregion
}

