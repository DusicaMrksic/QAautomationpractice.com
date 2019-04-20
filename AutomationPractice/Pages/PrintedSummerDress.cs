using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
   public class PrintedSummerDress
    {
        readonly IWebDriver driver;
        public By Addbtn = By.XPath("//button[@name='Submit']");
        public By ptc = By.XPath("//a[@title='Proceed to checkout']");

        public PrintedSummerDress(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("columns")));
        }
    }  
}