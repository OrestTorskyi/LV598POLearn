using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV598POLearn.pages
{
    class HeaderComponent : BasePage
    {
        #region Locators
        protected IWebElement ContactUsBtn { get { return Driver.FindElement(By.XPath("//div[contains(@id, 'contact')]/a")); } }
        protected IWebElement SignInBtn { get { return Driver.FindElement(By.XPath("//a[@class = 'login']")); } }
        #endregion
        public HeaderComponent(IWebDriver driver) : base(driver) { }
    }
}
