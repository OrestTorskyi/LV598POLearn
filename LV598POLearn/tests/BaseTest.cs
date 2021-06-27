using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using LV598POLearn.pages;

namespace LV598POLearn.tests
{
    class BaseTest
    {

        protected IWebDriver driver;

        [OneTimeSetUp]
        public void BeforeAllMethods()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }
    

        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            driver.Close();
            driver.Quit();
        }

        [SetUp]
        public void SetUp()
        {
            driver.Navigate().GoToUrl(@"http://automationpractice.com/index.php");
        }
    }
}

//private final String BASE_URL = "https://ita-social-projects.github.io/GreenCityClient/#";
//protected static WebDriver webDriver;


//    protected void getDriver()
//{
//    String webDriverPath = System.getenv("webdriver.chrome.driver");
//    System.setProperty("webdriver.chrome.driver", webDriverPath);
//    webDriver = new ChromeDriver();
//    WebDriverWait wait = new WebDriverWait(webDriver, 20);
//    WaitWrapper.setDefaultImplicitlyWait(webDriver);
//    webDriver.manage().window().maximize();
//    webDriver.get(BASE_URL);
//}


//@AfterClass
//    protected void tearDownClass()
//{
//    webDriver.close();
//    webDriver.quit();
//}