using AutomationPractice.Helpers;
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
        public void ThenCorrectIsDisplayed(string p0)
        {
           
        }
    }
}
