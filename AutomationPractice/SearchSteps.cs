using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice
{
    [Binding]
    public class SearchSteps : Base
    {
        Utilities ut = new Utilities(Driver);

        [Given(@"user enters a '(.*)' search term")]
        public void GivenUserEntersASearchTerm(string dress)
        {
            
            Homepage Dress = new Homepage(Driver);
            ut.EnterTextInElement(Dress.searchEnter, dress);
        }
        
        [Then(@"results for a '(.*)' search term are displayed")]
        public void ThenResultsForASearchTermAreDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
