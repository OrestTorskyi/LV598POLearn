using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LV598POLearn.pages
{
    public abstract class BasePage
    {
        //protected IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public IWebDriver Driver { get; private set; }
        #region 

        #endregion
    }
}
