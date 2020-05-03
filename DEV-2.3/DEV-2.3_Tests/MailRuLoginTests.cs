using System;
using DEV_2._3.PageObjects.MailRu;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DEV_2._3_Tests
{
    // The task asks to test only one of the services.
    [TestFixture]
    public class MailRuLoginTests
    {
        private IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            this.driver = new ChromeDriver();
            this.driver.Url = "https://mail.ru";
        }

        [Test]
        public void EmptyFieldsTest()
        {
            string Login = string.Empty;
            string Password = string.Empty;
            MailRuHomePage LoginPage = new MailRuHomePage(this.driver);

            Assert.Throws<MemberAccessException>(() => LoginPage.Login(Login, Password));
        }

        [Test]
        public void WrongFieldsTest()
        {
            string Login = "AbraKadabra79182";
            string Password = "BlaBla91283";
            MailRuHomePage LoginPage = new MailRuHomePage(this.driver);

            Assert.Throws<MemberAccessException>(() => LoginPage.Login(Login, Password));
        }

        [Test]
        public void WrongPasswordTest()
        {
            string Login = "BabeyFakeMail";
            string Password = "BlaBla91283";
            MailRuHomePage LoginPage = new MailRuHomePage(this.driver);

            Assert.Throws<MemberAccessException>(() => LoginPage.Login(Login, Password));
        }

        [Test]
        public void CorrectFieldsTest()
        {
            string Login = "BabeyFakeMail";
            string Password = "MegaPassword";
            MailRuHomePage LoginPage = new MailRuHomePage(this.driver);

            var NextPage = LoginPage.Login(Login, Password);

            Assert.True(NextPage.NewMessageButton.Displayed);
        }

        [TearDown]
        public void CloseBrowser()
        {
            this.driver.Quit();
        }
    }
}