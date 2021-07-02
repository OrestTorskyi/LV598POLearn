using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace LV598POLearn.SpecFlow.Hooks
{
    [Binding]
    public sealed class HooksInitialization
    {

        private readonly ScenarioContext _scenarioContext;

        public HooksInitialization(ScenarioContext scenarionContext) => _scenarioContext = scenarionContext;
      

        [BeforeScenario]
        public void BeforeScenario()
        {
            SeleniumDriver driver = new SeleniumDriver(_scenarioContext);
            _scenarioContext.Set(driver, "SeleniumDriver");
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _scenarioContext.Get<IWebDriver>("WebDriver").Quit();
        }
    }
}
