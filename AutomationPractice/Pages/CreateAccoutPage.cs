using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class CreateAccoutPage
    {
        readonly IWebDriver driver;
        public By FirstName = By.Id("customer_firstname");
        public By LastName = By.Id("customer_lastname");
        public By Password = By.Id("passwd");
        public By FirstName1 = By.Id("firstname");
        public By Lastname1 = By.Id("lastname");
        public By Address = By.Id("address1");
        public By City = By.Id("city");
        public By State = By.Id("id_state");
        public By Zip = By.Id("postcode");
        public By Mphone = By.Id("phone_mobile");
        public By Alias = By.Id("alias");
        public By Regbtn = By.Id("submitAccount");


        public CreateAccoutPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("account-creation_form")));
        }
    }
}
