using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV598POLearn.pages
{
    class FooterComponent : BasePage
    {
        #region Locators
        private IWebElement NewsletterInput { get { return Driver.FindElement(By.Id("newsletter-input"));} }
        private IWebElement EmailSubmitBtn { get { return Driver.FindElement(By.XPath("//div[contains(@id, 'newsletter')]//button[@type = 'submit']")); } }
        #endregion
        public FooterComponent(IWebDriver driver) : base(driver) { }

        #region Methods
        public T InputEmailAddressForNewsLetter<T>(T currentClass,String text)
        {
            NewsletterInput.Clear();
            NewsletterInput.SendKeys(text);
            EmailSubmitBtn.Click();
            return currentClass;
        }
        #endregion

    }
}
