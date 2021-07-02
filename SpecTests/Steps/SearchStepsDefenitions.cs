using LV598POLearn.SpecFlow;
using LV598POLearn.SpecFlow.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecTests.Steps
{
    [Binding]
    public class SearchStepsDefenitions 
    {

        private readonly ScenarioContext _scenarioContext;
       
        
     
       private MainPage mainPage;
        private SearchPage searchPage;
        public IWebDriver Driver { get; private set; }
        //[Given("Open browser")]
     
        //public void OpenBrowser()
        //{
         //   Driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").GetBrowser();
        //}
        //public IWebDriver Driver { get { return _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").GetBrowser(); } }
        public SearchStepsDefenitions(ScenarioContext scenarioContext) 
        {
            _scenarioContext = scenarioContext;
            Driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").GetBrowser();
            mainPage = new MainPage(Driver);
            searchPage = new SearchPage(Driver);
          
        }

        [Given(@"Website is opened")]
        public void GivenWebsiteIsOpened()
        {
            //Driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").GetBrowser();
            Driver.Url = "http://automationpractice.com/index.php";

        }


        [When("Click on search field")]
        public void WhenSearchFieldIsReady()
        {
            mainPage.ClickOnSearchField();
        }

        [When("The product is typed in search field(.*)")]
        public void WhenProductIsTyped(string product)
        {
            mainPage.EnterDataInSearchField(product);
        }

        [When("The searching button is clicked")]
        public void WhenSearchButtonClicked()
        {
            mainPage.ClickOnSearchButton();
        }

        [Then("Searching was completed")]
        public void ThenSearchAssert()
        {
            searchPage.getErrorText();
        }

        [Then("Error must be (.*)")]
        public void ProductWasNotSearched(string errotText)
        {
            Assert.AreEqual(searchPage.getErrorText(), errotText, "Failed assert");
        }
    }
}
