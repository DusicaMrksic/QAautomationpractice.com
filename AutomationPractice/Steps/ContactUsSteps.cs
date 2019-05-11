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
        
        [Given(@"user enter mandatory fields Subject Heading and email address")]
        public void GivenUserEnterAllMandatoryFields()
        {
            ContactUs cus = new ContactUs(Driver);
            ut.DropdownSelect(cus.SubjectHeadingDD, TestConstants.SubjectHeadingDD);
            //(cup.Subjectheading, heading)
            ut.EnterTextInElement(cus.MailAddress, ut.GenerateRandomEmail());
            //ut.EnterTextInElement(cus.Message, TestConstants.messagefield);
           
        }

        [Given(@"user enters '(.*)' message in message box")]
        public void GivenUserEntersMessageInMessageBox(string Dusica)
        {
            ContactUs mesagge = new ContactUs(Driver);
            ut.EnterTextInElement(mesagge.Message, Dusica);
        }


        [When(@"user clicks on Send button")]
        public void WhenUserClicksOnSendButton()
        {
            ContactUs Sendbt = new ContactUs(Driver);
            ut.ClickOnElement(Sendbt.sendbtn);

        }


        [Then(@"Message '(.*)' is present to the user")]
        public void ThenMessageIsPresentToTheUser(string message)
        {
            ContactUs Greenmsgn = new ContactUs(Driver);
            Assert.That(ut.ReturnTextFromElement(Greenmsgn.greenMessage).Contains(message), "Your message has been successfully sent to our team");
            //  Assert.True(ut.ElementDispayed(Greenmsgn.greenMessage), );
            //Assert.True(ut.TextPresentInElement("Your message has been successfully sent to our team.").Displayed);

        }


    }
}
