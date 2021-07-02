using NUnit.Framework;
using OpenQA.Selenium;
using SpecTests.Steps;
using TechTalk.SpecFlow;

namespace LV598POLearn.SpecFlow.Pages
{
    public class SearchPage 
    {
        private readonly IWebDriver driver;

        public SearchPage( IWebDriver driver) { this.driver = driver; }
        

        private IWebElement SearchErrorText => driver.FindElement(By.XPath("//p[@class='alert alert-warning']"));

        public string getErrorText()
        {
            return SearchErrorText.Text;
        }

        public void CheckIsProductSearched()
        {
            string result = getErrorText();
            string expectedResult = ""; 
            Assert.AreEqual(expectedResult,result, "Search was done not correctly");

            
        }
    }
}