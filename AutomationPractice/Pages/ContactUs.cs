using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class ContactUs
    {
        readonly IWebDriver driver;
        public By SubjectHeadingDD = By.Id("id_contact");
        public By MailAddress = By.Id("email");
        public By Message = By.Id("message");
        public By sendbtn = By.Id("submitMessage");
        public By greenMessage = By.XPath("//*[text()[contains(.,'Your message has been successfully sent to our team.')]]");

        public ContactUs(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("contact")));
        }
    }
}
