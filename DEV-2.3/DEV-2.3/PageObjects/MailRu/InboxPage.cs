using OpenQA.Selenium;

namespace DEV_2._3.PageObjects.MailRu
{
    //I think the comments for my PageObjects are not necessary, everything is clear
    public class InboxPage
    {
        private IWebDriver driver;

        public IWebElement NewMessageButton => this.driver.FindElement(By.XPath("//a[@title='Написать письмо']"), 10, 20);

        public IWebElement RecipientBox => this.driver.FindElement(By.XPath("//div[@data-type='to']/div/div/label/div/div/input"), 10, 20);

        public IWebElement MessageTextBox => this.driver.FindElement(By.XPath("//div[contains(@class,'editable-container')]/div"), 10, 20);

        public IWebElement SendMessageButton => this.driver.FindElement(By.XPath("//span[@title='Отправить']/span"), 10, 20);

        public IWebElement OpenLastReceivedMessageButton => this.driver.FindElement(By.XPath("//a[@class='llc js-tooltip-direction_letter-bottom js-letter-list-item llc_normal'][1]"), 10, 20);

        public InboxPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public InboxPage WriteNewMessage(string Recipient, string MessageText)
        {
            this.NewMessageButton.Click();
            this.RecipientBox.SendKeys(Recipient);
            this.MessageTextBox.Clear();
            this.MessageTextBox.SendKeys(MessageText);
            this.SendMessageButton.Click();

            return this;
        }

        public MessageReadingPage ReadLastMessage()
        {
            this.OpenLastReceivedMessageButton.Click();

            return new MessageReadingPage(this.driver);
        }
    }
}