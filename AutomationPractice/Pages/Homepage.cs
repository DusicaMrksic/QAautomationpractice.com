using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class Homepage
    {
        readonly IWebDriver driver;

        public By signIn = By.ClassName("login");
        public By searchEnter = By.Id("search_query_top");
        public By searchBtn = By.Name("submit_search");
        public By ContactUsBtn = By.XPath("//a[@title='Contact Us']");


        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("columns"))) ;

        }
       
    }
}
