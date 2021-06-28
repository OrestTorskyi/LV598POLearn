using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LV598POLearn.pages
{
    class MyAccount : BasePage
    {

        private IWebElement ImageLogo { get { return Driver.FindElement(By.CssSelector(".logo.img-responsive")); } }
        public MyAccount(IWebDriver driver) : base(driver) { }

        public MainPage goToMainPage()
        {
            ImageLogo.Click();
            return new MainPage(Driver);
        }
    }
}
