using LV598POLearn.pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV598POLearn.tests
{
    class ChangePersonalInformationTest : BaseTest
    {
        MyPersonalInformationPage myPersonalInformationPage;

        [SetUp]
        public void goToMyPersonalInformationWithLoggedInUser()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.GetHeader();
            MyAccount myAccount = mainPage.goToSignInPage().enterEmail().enterPassword().pressSignInButton();
            myAccount.clickOnMyPersonalInformation();
        }

        [Test]
        public void verifySavePersonalInformationChangesTest()
        {
            myPersonalInformationPage = new MyPersonalInformationPage(driver)
               .clickOnSocialTitle()
               .inputFirstName("Anna")
               .inputLastName("Petruk")
               .inputCurrentPassword("jkljkl")
               .clickOnRecieveSpecialOffers()
               .clickOnSaveButton();

            string actualMessage = myPersonalInformationPage.getSaveMessage();
            string expectedMessage = "Your personal information has been successfully updated.";
            Assert.AreEqual(expectedMessage, actualMessage, "Sorry, your data wasn't save.Try again.");
        }
    }
}
