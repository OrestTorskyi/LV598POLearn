using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV598POLearn.pages
{
    abstract class BasePopup : BasePage
    {
        private BasePopup(IWebDriver driver) : base(driver) { }
    }

}
