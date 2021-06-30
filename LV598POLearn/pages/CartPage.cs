using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LV598POLearn.pages
{
    public class CartPage : BaseCommon
    {
        #region Locators
        private IWebElement DeleteButton { get { return Driver.FindElement(By.XPath("//a[@title='Delete']")); } }
        private IWebElement WarningMessage { get { return Driver.FindElement(By.CssSelector("#center_column > p")); } }




        #endregion

        #region Components
        #endregion



        public CartPage(IWebDriver driver) : base(driver)
        {
        }
        #region Methods

        public void DeleteProduct()
        {
            Thread.Sleep(300);
            DeleteButton.Click();


        }
        public string WarnningMessage()
        {
            Thread.Sleep(800);
            return WarningMessage.Text;



        }
        #endregion
    }
}
