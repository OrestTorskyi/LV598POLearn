using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LV598POLearn.pages;
using System.Threading;

namespace LV598POLearn.tests
{
    class ValidSearchTest : BaseTest
    {
        MainPage mainPage;
        [SetUp]
        public void GoToMainPage()
        {
            mainPage = new MainPage(driver);
            mainPage.GetHeader();
        }

        [Test]
        public void verifySearchItemsTest()
        {
            mainPage.SearchFor("T-shirt");
        }

        [Test]
        public void verifyListViewTest()
        {
            SearchQueryPage search = mainPage.SearchFor("T-shirt")
                .clickOnListViewButton();
            Thread.Sleep(2000);
        }
    }
}
