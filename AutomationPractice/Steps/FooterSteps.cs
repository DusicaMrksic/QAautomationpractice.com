﻿using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class FooterSteps:Base 
    {
        Footer InformationLink = new Footer(Driver);
        [When(@"user clicks on '(.*)' option")]
        public void WhenUserClicksOnOption(string Link)
        {  
            InformationLink.ClickOnInformationLink(Link);
        }
        
        [Then(@"correct '(.*)' is displayed")]
        public void ThenCorrectIsDisplayed(string link)
        {

            Assert.That(InformationLink.InformationPageDispayed(link), Is.True, "Correct page does not dispalyed");
        }

        [When(@"user clicks on '(.*)' section")]
        public void WhenUserClicksOnSection(string title)
        {
            InformationLink.ClickOnInformationLink(title);
        }

        [Then(@"correct my account '(.*)' is displayed")]
        public void ThenCorrectMyAccountIsDisplayed(string page)
        {

            //Assert.That(InformationLink.MyAccountPageDispayed(page), Is.True, "Correct page does not dispalyed");
            Assert.True(InformationLink.MyAccountPageDispayed(page), "Correct page does not dispalyed");
        }

    }
}
