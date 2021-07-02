using OpenQA.Selenium;
using SpecTests.Drivers;
using SpecTests.Steps;
using TechTalk.SpecFlow;

namespace LV598POLearn.SpecFlow.Pages
{
    public  class MainPage


    {
    private const string Url = "http://automationpractice.com/index.php";

    private readonly IWebDriver _driver;
        public IWebDriver Driver { get; private set; }
      

        public MainPage(IWebDriver driver) { this.Driver = driver; }
    
        private IWebElement SearchField { get { return Driver.FindElement(By.XPath("//input[@id='search_query_top']")); } }
      
        private IWebElement SearchButton =>
        Driver.FindElement(By.XPath("//button[@class='btn btn-default button-search']"));

    public void ClickOnSearchField()
    {
        SearchField.Click();
    }

    public void EnterDataInSearchField(string searchItem)
    {
        SearchField.SendKeys(searchItem);
    }

    public void ClickOnSearchButton()
    {
        SearchButton.Click();
    }



    }
}