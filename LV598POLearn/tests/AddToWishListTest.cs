using LV598POLearn.pages;
using NUnit.Framework;

namespace LV598POLearn.tests
{
    class AddToWishListTest : BaseTest
    {
        [Test]
        public void addToWishList()
        {
            MainPage mainPage = loadApplicationWithLoggedInUser();
            string expected = "My wishlist";
            string actual = mainPage.chooseFirstProductItem()
                                     .addToWishList()
                                     .closePopUp()
                                     .goToMyAccount()
                                     .goToWishListComponent()
                                     .getWishListName();
            Assert.AreEqual(actual, expected);
        }
      
    }
}
