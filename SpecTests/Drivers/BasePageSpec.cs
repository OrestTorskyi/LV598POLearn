using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecTests.Drivers
{
    public abstract class BasePageSpec
    {
        public BasePageSpec(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public IWebDriver Driver { get; private set; }
    }
}
