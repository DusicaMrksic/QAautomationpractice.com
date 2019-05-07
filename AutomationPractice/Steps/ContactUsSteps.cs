using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class ContactUsSteps : Base
    {
        Utilities ut = new Utilities(Driver);

        [Given(@"user opens Contact us page")]
        public void GivenUserOpensContactUsPage()
        {
            Homepage contactUs = new Homepage(Driver);
            ut.ClickOnElement(contactUs.ContactUsBtn);
        }
        
        [Given(@"user enter all mandatory fields")]
        public void GivenUserEnterAllMandatoryFields()
        {
            ContactUs cus = new ContactUs(Driver);
            ut.DropdownSelect(cus.SubjectHeadingDD, TestConstants.SubjectHeadingDD);
            string anyemail = ut.GenerateRandomEmail();
            ut.EnterTextInElement(cus.MailAddress, anyemail);
            ut.EnterTextInElement(cus.Message, TestConstants.messagefield);
            //  ContactUs mesagge = new ContactUs(Driver);
            // ut.EnterTextInElement(mesagge.Message, be);
        }

        [When(@"user clicks on Send button")]
        public void WhenUserClicksOnSendButton()
        {
            ContactUs Sendbt = new ContactUs(Driver);
            ut.ClickOnElement(Sendbt.sendbtn);

        }

        [Then(@"Green message is dispayed")]
        public void ThenGreenMessageIsDispayed()
        {
            //ContactUs Greenmsgn = new ContactUs(Driver);
            //Assert.True(ut.ElementDispayed(Greenmsgn.greenMessage), "Message has been successfully sent to cs.");
            string gn = ScenarioContext.Current.Get<string>(TestConstants.green);
            Assert.True(ut.TextPresentInElement(gn).Displayed, "User is not dispayed");

        }
    }
}
