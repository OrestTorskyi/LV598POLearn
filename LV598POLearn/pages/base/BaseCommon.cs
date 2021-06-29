using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV598POLearn.pages
{
    abstract class BaseCommon<T> : BasePage
    {

        HeaderComponent headerComponent;

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
        #endregion
    }
}
