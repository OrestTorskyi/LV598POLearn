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

        public MainPage loadApplicationWithLoggedInUser()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.GetHeader();
            MyAccount myAccount = mainPage.goToSignInPage().enterEmail().enterPassword().pressSignInButton();
            myAccount.GetHeader();
            return myAccount.GoToMainPage();
        }
    }
}