using LV598POLearn.pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace LV598POLearn.tests
{
    class VerifyCorrectMessageForEmptyCartTest : BaseTest
    {


        CartPage cartPage;
        MainPage mainPage;

        [SetUp]
        public void GetSomeProductsOnMainPage()
        {
            mainPage = loadApplicationWithLoggedInUser();
            mainPage.ChooseBestSellersProducts()
                    .GetBestSellerProduct()
                    .GetAddtoCartProducts()
                    .ProceedToChecckout();



        }


        [Test]
        public void MyTest()
        {


            cartPage = new CartPage(driver);
            cartPage.DeleteProduct();

            string actualMessage = cartPage.GetTextWarningMessage();
            string expectedMessage = "Your shopping cart is empty.";
            Assert.AreEqual(expectedMessage, actualMessage, "Message is WRONG!!!");


        }

    }
}
