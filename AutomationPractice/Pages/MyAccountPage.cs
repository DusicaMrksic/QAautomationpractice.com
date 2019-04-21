using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
   public class MyAccountPage
    {
        readonly IWebDriver driver;
        //lokatori
        public By SignOutBtn = By.ClassName("logout");
        public By WishL = By.ClassName("lnk_wishlist");
        
        public MyAccountPage(IWebDriver driver)

        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("my-account")));
        }

    }

        

}
