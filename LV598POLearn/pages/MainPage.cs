using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LV598POLearn.pages
{
    public class MainPage : BaseCommon
    {

        #region Locators
       
        private IWebElement ButtonSignIn { get { return Driver.FindElement(By.CssSelector(".login")); } }
        #endregion

        #region Components
        #endregion

        public MainPage(IWebDriver driver) : base(driver) { }
        
        #region Methods
        #endregion
    }
}
