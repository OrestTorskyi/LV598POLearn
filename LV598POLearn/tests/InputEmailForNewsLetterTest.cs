using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LV598POLearn.pages;
using LV598POLearn.utils;
using NUnit.Framework;

namespace LV598POLearn.tests
{
    class InputEmailForNewsLetterTest : BaseTest
    {
        MainPage mainPage;
        [SetUp]
        public void GoToMainPage()
        {
            mainPage = new MainPage(driver);
            mainPage.GetFooter();
        }

        

        [Test]
        public void verifyAlertWhenValidEmailTest()
        {
            string randomEmail = RandomGenerator.GenerateWord(7, 97, 122);
            string expectedMessage = "Newsletter : You have successfully subscribed to this newsletter.";
            mainPage.InputEmailForNewsletter<MainPage>(mainPage, randomEmail + "@gmail.com");
            mainPage.clickOnSubmitEmailBtn<MainPage>(mainPage);
            mainPage.GetHeader();
            string actualMessage = mainPage.getAlertMessage<MainPage>(mainPage).getTextOfAlertMessage();
            Assert.AreEqual(expectedMessage, actualMessage.Trim(), "The messages aren't the same!");
        }

        [Test]
        public void verifyAlertWhenInvalidEmailTest()
        {
            string expectedMessage = "Newsletter : Invalid email address.";
            mainPage.InputEmailForNewsletter<MainPage>(mainPage, "aslkdj").clickOnSubmitEmailBtn<MainPage>(mainPage).GetHeader();
            string actualMessage = mainPage.getAlertMessage<MainPage>(mainPage).getTextOfAlertMessage();
            Assert.AreEqual(expectedMessage, actualMessage.Trim(), "The messages aren't the same!");
        }

        [Test]
        public void verifyAlertWhenRegisteredEmailTest()
        {
            string randomEmail = RandomGenerator.GenerateWord(7, 97, 122);
            string expectedMessage = "Newsletter : This email address is already registered.";
            mainPage.InputEmailForNewsletter<MainPage>(mainPage, randomEmail + "@gmail.com").clickOnSubmitEmailBtn<MainPage>(mainPage);
            mainPage.InputEmailForNewsletter<MainPage>(mainPage, randomEmail + "@gmail.com").clickOnSubmitEmailBtn<MainPage>(mainPage).GetHeader();
            string actualMessage = mainPage.getAlertMessage<MainPage>(mainPage).getTextOfAlertMessage();
            Assert.AreEqual(expectedMessage, actualMessage.Trim(), "The messages aren't the same!");
        }

    }
}
