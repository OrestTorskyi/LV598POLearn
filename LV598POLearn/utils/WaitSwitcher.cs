using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV598POLearn.utils
{
    public class WaitSwitcher
    {
        
        public static void SetExcplicitlyWait<T>(IWebDriver driver, int seconds, Func<IWebDriver, T> condition)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(condition);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
}
