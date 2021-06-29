using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV598POLearn.pages
{
    public abstract class BaseCommon : BasePage
    {

        private HeaderComponent headerComponent;
        private FooterComponent footerComponent;
        private MenuComponent menuComponent;
        protected BaseCommon(IWebDriver driver) : base(driver) { }

        #region Menu

        #endregion

        #region Footer elements

        #endregion

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

        public void GetMenu()
        {
            menuComponent = new MenuComponent(Driver);
        }

        public T InputEmailForNewsletter<T>(T currentClass, String text)
        {
            return footerComponent.InputEmailAddressForNewsLetter(currentClass, text);
        }
        #endregion
    }
}
