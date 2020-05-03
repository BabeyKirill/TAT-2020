using OpenQA.Selenium;
using System;

namespace DEV_2._3
{
    public static class WebDriverExtensions
    {
        /// <summary>
        /// Searching for the first IWebElement by specified search method 
        /// and specified maximum search time. Returns WebDriverTimeoutException if time runs out
        /// </summary>
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds <= 0)
            {
                return driver.FindElement(by);
            }

            IWebElement element;
            DateTime endWaitTime = DateTime.Now.AddSeconds(timeoutInSeconds);

            while (DateTime.Now < endWaitTime)
            {
                try
                {
                    element = driver.FindElement(by);
                    return element;                  
                }
                catch (StaleElementReferenceException)
                {
                }
                catch (NoSuchElementException)
                {
                }
            }

            throw new WebDriverTimeoutException();
        }

        /// <summary>
        /// Searching for the first displayed IWebElement by specified search method 
        /// and specified maximum search time. Returns WebDriverTimeoutException if time runs out
        /// </summary>
        public static IWebElement FindDisplayedElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {           
            if (timeoutInSeconds <= 0)
            {
                return driver.FindElement(by);
            }

            IWebElement element;
            DateTime endWaitTime = DateTime.Now.AddSeconds(timeoutInSeconds);

            while (DateTime.Now < endWaitTime)
            {
                try
                {
                    element = driver.FindElement(by);
                    if (element.Displayed == true)
                    {
                        return element;
                    }
                }
                catch (StaleElementReferenceException)
                {
                }
                catch (NoSuchElementException)
                {
                }
            }

            throw new WebDriverTimeoutException();
        }

        /// <summary>
        /// Return false if the IWebElement does not displayed within the specified time, else returns true
        /// </summary>
        public static bool Displayed(this IWebElement element, int timeoutInMilliseconds)
        {
            if (timeoutInMilliseconds > 0)
            {
                DateTime endWaitTime = DateTime.Now.AddMilliseconds(timeoutInMilliseconds);

                while (DateTime.Now < endWaitTime)
                {
                    try
                    {
                        if (element.Displayed == true)
                        {
                            return true;
                        }
                    }
                    catch(StaleElementReferenceException)
                    {
                    }
                }

                return false;
            }
            else
            {
                return element.Displayed;
            }
        }
    }
}