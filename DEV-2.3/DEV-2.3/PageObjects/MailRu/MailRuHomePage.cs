using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DEV_2._3.PageObjects.MailRu
{
    /// <summary>
    /// Expected driver.Url = "https://mail.ru"
    /// </summary>
    public class MailRuHomePage
    {     
        private IWebDriver driver;

        public IWebElement LoginBox => this.driver.FindElement(By.XPath("//input[@id='mailbox:login']"), 10, 20);

        public IWebElement LoginButton => this.driver.FindElement(By.XPath("//*[@id='mailbox:submit']"), 10, 20);

        public IWebElement PasswordBox => this.driver.FindElement(By.XPath("//*[@id='mailbox:password']"), 10, 20);     

        public IWebElement LoginErrorMessage => this.driver.FindElement(By.XPath("//*[@id='mailbox:error']"), 10, 20);

        public MailRuHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public InboxPage Login(string Login, string Password)
        {
            this.LoginBox.SendKeys(Login);
            this.LoginButton.Click();

            if (this.LoginErrorMessage.Displayed(500, 20))
            {
                throw new MemberAccessException();
            }

            this.PasswordBox.SendKeys(Password);
            this.LoginButton.Click();

            if (this.LoginErrorMessage.Displayed(500, 20))
            {
                throw new MemberAccessException();
            }

            return new InboxPage(this.driver);
        }
    }
}