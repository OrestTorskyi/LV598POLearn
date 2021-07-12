using LV598POLearn.pages;
using NUnit.Framework;

namespace LV598POLearn.tests
{
    class AddToProductCartTest : BaseTest
    {
        CartPage cartPage;
        MainPage mainPage;

        [SetUp]
        public void AddProduct()
        {
            mainPage = loadApplicationWithLoggedInUser();
            mainPage.ChooseBestSellersProducts()
                    .GetBestSellerProduct()
                    .GetAddtoCartProducts()
                    .ProceedToChecckout();
        }

        [Test]
        public void CheckShoppingCart()
        {
            cartPage = new CartPage(driver);
            cartPage.GetTextContainsMessage();
            string expected = "Your shopping cart contains: 1 Product";
            string actualMessage = cartPage.GetTextContainsMessage();
            Assert.AreEqual(actualMessage, expected, "Shopping cart contains a product");
        }
    }
}
