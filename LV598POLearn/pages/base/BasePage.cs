using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LV598POLearn.pages
{
    abstract class BasePage
    {
        //protected IWebDriver driver;
        public BasePage(IWebDriver driver)  
        {
            this.Driver = driver;
        }

        //public void NavigateToURL()
        //{
        //    Driver.Navigate().GoToUrl(@"https://www.google.com/");
        //}

        public IWebDriver Driver { get; private set; }
        #region 

        #endregion
    }
}
