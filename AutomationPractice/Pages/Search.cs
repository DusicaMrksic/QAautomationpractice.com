using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    public class Search
    {
        readonly IWebDriver driver;
        //public By fp = By.XPath("//a[@title='Printed Summer Dress']");
        public By fnp = By.CssSelector(".product_img_link .replace-2x");
        public By pic = By.Id("image-block");
        public Search(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("columns-container")));

        }
    }
}
