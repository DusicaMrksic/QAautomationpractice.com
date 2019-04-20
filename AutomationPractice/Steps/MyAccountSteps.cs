using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class MyAccountSteps:Base
    {
        Utilities ut = new Utilities(Driver);

        [Given(@"user opens sign in page")]
        public void GivenUserOpensSingInPage()
        {
            Homepage hp = new Homepage(Driver);
            ut.ClickOnElement(hp.signIn);
        }
        
        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            //objekat klase AP,metoda se poziva preko objekta ut
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.username, TestConstants.Username);
            ut.EnterTextInElement(ap.password, TestConstants.Password);

        }
        
        [StepDefinition(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()
        {
            AuthenticationPage btn = new AuthenticationPage(Driver);
            ut.ClickOnElement(btn.signInBtn);

        }
        
        [Then(@"user will be logged in")]
        public void ThenUserWilBeLoggedIn()
        {
            MyAccountPage map = new MyAccountPage(Driver);
            // imlementacija Then scenarija uvek ima Assert ,uvek, uvek
            Assert.True(ut.ElementDispayed(map.SignOutBtn), "User is not logged in");
        }

        [When(@"user opens my wishlist")]
        public void WhenUserOpensMyWishlist()
        {
            MyAccountPage mwl = new MyAccountPage(Driver);
            ut.ClickOnElement(mwl.WishL);
        }

        [Then(@"user can add new wishlist")]
        public void ThenUserCanAddNewWishlist()
        {
            //svaki Then ima Assert, objekat se pravi i veze se na kojoj je stranici

            MyWishList NWl = new MyWishList(Driver);
            Assert.True(ut.ElementDispayed(NWl.NewWL), "New wishlist can not add"); 
            
        }

        [Given(@"initiates a flow for creating an account")]
        public void GivenInitiatesAFowForCreatingAnAccount()
        {
            //lokator kreira se objekat
            AuthenticationPage ap = new AuthenticationPage(Driver);
            //deklarisem novu promenljivu tipa string email i dodeliti vrednost iz utilities klase
            string email = ut.GenerateRandomEmail();
            ut.EnterTextInElement(ap.emailAddress, email);
            ut.ClickOnElement(ap.caBtn); 
        }

        [Given(@"user enters all required personal details")]
        public void GivenUserEntersAllRequiredPersonalDetails()
        {
            ScenarioContext.Current.Pending();
        } 

        [When(@"submits the sign up form")]
        public void WhenSubmitsTheSignUpForm()
        {
            ScenarioContext.Current.Pending();
        }


    }

}
