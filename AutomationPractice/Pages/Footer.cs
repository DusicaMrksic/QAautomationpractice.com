using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class Footer
    {
        readonly IWebDriver driver;
        public Footer(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("footer-container")));
        }

        public void ClickOnInformationLink(string title)

        {
            By link = By.CssSelector(".toggle-footer [title='" + title + "']");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(link)).Click();


        }

        public bool InformationPageDispayed(string page)
            {
            By link = By.XPath("//*[@class='navigation_page'][contains(text(),'" + page + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(link)).Displayed;

        }

        public void ClickOnMyAccountLink(string title)

        {
            By link = By.CssSelector(".bullet [title='" + title + "']");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(link)).Click();
        }

        public bool MyAccountPageDispayed(string page)
        {
            By link = By.XPath("//*[@class='navigation_page'][contains(text(),'" + page + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(link)).Displayed;

        }

    }
}
