using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LV598POLearn.pages
{
    public abstract class BaseCommon : BasePage
    {

        private HeaderComponent headerComponent;
        private FooterComponent footerComponent;
        protected BaseCommon(IWebDriver driver) : base(driver) { }


        #region Methods
        //generic
        public void GetHeader()
        {
            headerComponent = new HeaderComponent(Driver);
        }

        public void GetFooter()
        {
            footerComponent = new FooterComponent(Driver);
        }

        public T InputEmailForNewsletter<T>(T currentClass, String text)
        {
            return footerComponent.InputEmailAddressForNewsLetter(currentClass, text);
        }

        public SignIn goToSignInPage()
        {
            return headerComponent.ClickOnSighInBtn();
        }

        public MainPage goToMainPage()

        {
            Thread.Sleep(500);
            return headerComponent.goToMainPage();
        }
        public SearchQueryPage SearchFor(String text)
        {
            return headerComponent.SearchSomeProducts(text);
        }
        #endregion
    }
}
