using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using System;
using TechTalk.SpecFlow;
using System.Threading;
using System.Drawing.Imaging;
using OpenQA.Selenium.Support.Events;


namespace AutomationPractice.Steps
{
    [Binding]
    public class CheckoutSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        [Given(@"user enters a DRESS search term")]
        public void GivenUserEntersADRESSSearchTerm()
        {
            Homepage search = new Homepage(Driver);
            ut.EnterTextInElement(search.searchEnter, TestConstants.Search);
        }
        
        [StepDefinition(@"user submits the search")]
        public void GivenUserSubmitsTheSearch()
        {
            Homepage searchb = new Homepage(Driver);
            ut.ClickOnElement(searchb.searchBtn);
        }
        
        [Given(@"opens first product from the list")]
        public void GivenOpensFirstProductFromTheList()
        {
            Search FirstP = new Search(Driver);
            //IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            //js.ExecuteScript("window.scrollBy(0,820)");
            //ut.ElementDispayed(FirstP.fp);
            //Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
            //ss.SaveAsFile("C:\\ab1.jpg".ToString(), ScreenshotImageFormat.Jpeg);
            //Thread.Sleep(10000);
            ut.ClickOnElement(FirstP.fnp);
            //ss.SaveAsFile("C:\\ah.jpg".ToString(), ScreenshotImageFormat.Jpeg);
            //Thread.Sleep(10000);
          ut.ClickOnElement(FirstP.pic);
           //ss.SaveAsFile("C:\\ab.jpg".ToString(), ScreenshotImageFormat.Jpeg);

        }

        [When(@"user clicks on add to cart button")]
        public void WhenUserClicksOnAddToCartButton()
        {
            PrintedSummerDress Cartbtn = new PrintedSummerDress(Driver);
            ut.ClickOnElement(Cartbtn.Addbtn);
        }
        
        [When(@"user proceeds to checkout")]
        public void WhenUserProceedsToCheckout()
        {
            PrintedSummerDress Checkoutbtn = new PrintedSummerDress(Driver);
            ut.ClickOnElement(Checkoutbtn.ptc);
        }
        
        [Then(@"cart page is opened")]
        public void ThenCartPageIsOpened()
        {
            YourShoppingCart ysc = new YourShoppingCart(Driver);
            Assert.True(ut.ElementDispayed(ysc.total), "Product is not add to cart");
        }
    }
}
