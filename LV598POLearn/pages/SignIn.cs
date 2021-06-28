using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LV598POLearn.pages
{
    class SignIn : BaseCommon
    {
        private IWebElement InputEmailAddress { get { return Driver.FindElement(By.Id("email")); } }
        private IWebElement InputPassword { get { return Driver.FindElement(By.Id("passwd")); } }
        private IWebElement ButtonSignIn { get { return Driver.FindElement(By.Id("SubmitLogin")); } }
        private const string login = "fvxthesjrgvwyuaqmz@twzhhq.com";
        private const string password = "jkljkl";
        public SignIn(IWebDriver driver) : base(driver) { }

        public SignIn enterEmail()
        {
            InputEmailAddress.SendKeys(login);
            return this;
        }
        public SignIn enterPassword()
        {
            InputPassword.SendKeys(password);
            return this;
        }
        public MyAccount pressSignInButton()
        {
            ButtonSignIn.Click();
            return new MyAccount(Driver);
        }
    }

}
