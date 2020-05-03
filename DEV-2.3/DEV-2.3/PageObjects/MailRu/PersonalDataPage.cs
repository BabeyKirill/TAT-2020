using OpenQA.Selenium;

namespace DEV_2._3.PageObjects.MailRu
{
    public class PersonalDataPage
    {
        private IWebDriver driver;

        public IWebElement NickNameBox => this.driver.FindElement(By.XPath("//*[@id='nickname']"), 10);

        public IWebElement SaveChangesButton => this.driver.FindElement(By.XPath("//button[@data-test-id='save-button']"), 10);

        public IWebElement ShowProfileButton => this.driver.FindElement(By.XPath("//i[@id='PH_user-email']"), 10);

        public IWebElement PersonalDataButton => this.driver.FindElement(By.XPath("//div[@class='x-ph__menu__dropdown_auth__links']/a[2]"), 10);


        public PersonalDataPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public PersonalDataPage ChangeNickName(string NickName)
        {
            this.NickNameBox.Clear();
            this.NickNameBox.SendKeys(NickName);
            this.SaveChangesButton.Click();
            this.ShowProfileButton.Click();
            this.PersonalDataButton.Click();

            return this;
        }
    }
}