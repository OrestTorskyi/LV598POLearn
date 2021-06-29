﻿using OpenQA.Selenium;
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
        private IWebElement ContactUsBtn { get { return Driver.FindElement(By.XPath("//div[contains(@id, 'contact')]/a")); } }
        private IWebElement SignInBtn { get { return Driver.FindElement(By.XPath("//a[@class = 'login']")); } }
        private IWebElement InputSearchField { get { return Driver.FindElement(By.Id("search_query_top")); } }
        private IWebElement SubmitSearchQueryBtn { get { return Driver.FindElement(By.XPath("//button[@name = 'submit_search']")); } }
        private IWebElement ImageLogo { get { return Driver.FindElement(By.CssSelector(".logo.img-responsive")); } }
        private IWebElement alertMessage;
        #endregion
        public HeaderComponent(IWebDriver driver) : base(driver) { }

        #region Methods
        public SignIn ClickOnSighInBtn()
        {
            SignInBtn.Click();
            return new SignIn(Driver);
        }
        public SearchQueryPage SearchSomeProducts(string text)
        {
            InputSearchField.Clear();
            InputSearchField.SendKeys(text);
            SubmitSearchQueryBtn.Click();
            return new SearchQueryPage(Driver);
        }
        public MainPage GoToMainPage()
        {
            ImageLogo.Click();
            return new MainPage(Driver);
        }

        public T GetAlertMessage<T>(T currentClass)
        {
            alertMessage = Driver.FindElement(By.XPath("//p[contains(@class, 'alert')]"));
            return currentClass;
        }

        public String GetTextAlertMessage()
        {
            return alertMessage.Text;
        }
        #endregion
    }
}
