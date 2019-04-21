using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Helpers
{
   public class Utilities
    {
        readonly IWebDriver driver;
        //dodaje se randome objekat da bi se svaki put novi mail upisivao
        private static readonly Random RandomName = new Random();
        public Utilities(IWebDriver driver)
        {
            this.driver = driver;
        }
       
        public void ClickOnElement(By selector)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(selector)).Click();
         }

       public void EnterTextInElement(By selector, string text)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector)).SendKeys(text);

        }
        public bool ElementDispayed(By selector)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector)).Displayed;
        }
        //metoda koja vraca vrednost je string, void izvrsava

        public string GenerateRandomEmail()
        {
            return string.Format("email{0}@mailnator.com", RandomName.Next(100000, 1000000));

        }
        // metoda za dropdown
        public void DropdownSelect(By select,string option)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(select));
            //nova varijabla
            var dropdown = driver.FindElement(select);
            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText(option);

        }
    }
}
