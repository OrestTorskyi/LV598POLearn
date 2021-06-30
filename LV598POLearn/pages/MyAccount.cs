using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LV598POLearn.pages
{
    public class MyAccount : BaseCommon
    {
        public MyAccount(IWebDriver driver) : base(driver) { }

        private IWebDriver driver { get; }

        private IWebElement lnkMyPersonalInformation => driver.FindElement(By.LinkText("Information"));

        public void clickOnMyPersonalInformation() => lnkMyPersonalInformation.Click();
    }
}
