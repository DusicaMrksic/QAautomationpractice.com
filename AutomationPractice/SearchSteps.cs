using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice
{
    [Binding]
    public class SearchSteps : Base
    {
        

        [Given(@"user enters a '(.*)' search term")]
        public void GivenUserEntersASearchTerm(string dress)
        {
            Utilities ut = new Utilities(Driver);
            Homepage Dress = new H
        }
        
        [When(@"user submits the search")]
        public void WhenUserSubmitsTheSearch()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"results for a '(.*)' search term are displayed")]
        public void ThenResultsForASearchTermAreDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
