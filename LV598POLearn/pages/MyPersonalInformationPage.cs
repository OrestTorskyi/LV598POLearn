using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV598POLearn.pages
{
    class MyPersonalInformationPage: BaseCommon
    {
        public MyPersonalInformationPage(IWebDriver driver) : base(driver) { }

        private IWebDriver driver { get; }

        #region Locators
        private IWebElement btnSocialTitle => driver.FindElement(By.Id("id_gender2"));
        private IWebElement fieldFirstName => driver.FindElement(By.Id("firstname"));
        private IWebElement fieldLastName => driver.FindElement(By.Id("lastname"));
        private IWebElement fieldCurrentPassword => driver.FindElement(By.Id("old_passwd"));
        private IWebElement checkBoxRecieveSpecialOffers => driver.FindElement(By.Id("optin"));
        private IWebElement btnSave => driver.FindElement(By.Name("submitIdentity"));
        private IWebElement saveMessage => driver.FindElement(By.CssSelector("p.alert.alert-success"));
        #endregion

        public MyPersonalInformationPage clickOnSocialTitle()
        {
            btnSocialTitle.Click();
            return this;
        }
        public MyPersonalInformationPage inputFirstName(string name)
        {
            fieldFirstName.Clear();
            fieldFirstName.SendKeys(name);
            return this;
        }

        public MyPersonalInformationPage inputLastName(string lastName)
        {
            fieldLastName.Clear();
            fieldLastName.SendKeys(lastName);
            return this;
        }

        public MyPersonalInformationPage inputCurrentPassword(string password)
        {
            fieldCurrentPassword.Clear();
            fieldCurrentPassword.SendKeys(password);
            return this;
        }

        public MyPersonalInformationPage clickOnRecieveSpecialOffers()
        {
            checkBoxRecieveSpecialOffers.Click();
            return this;
        }

        public MyPersonalInformationPage clickOnSaveButton()
        {
            btnSave.Click();
            return this;
        }

        public string getSaveMessage()
        {
            return saveMessage.Text;
        }
    }
}
