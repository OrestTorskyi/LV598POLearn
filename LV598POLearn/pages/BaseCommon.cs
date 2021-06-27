using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV598POLearn.pages
{
    abstract class BaseCommon : BasePage
    {

        protected BaseCommon(IWebDriver driver) : base(driver) { }

        #region Header elements
        protected IWebElement ContactUsBtn { get { return Driver.FindElement(By.XPath("//div[contains(@id, 'contact')]/a"));} }
        protected IWebElement SignInBtn { get { return Driver.FindElement(By.XPath("//a[@class = 'login']")); } }
        #endregion

        #region Menu

        #endregion

        #region Footer elements

        #endregion
    }
}
