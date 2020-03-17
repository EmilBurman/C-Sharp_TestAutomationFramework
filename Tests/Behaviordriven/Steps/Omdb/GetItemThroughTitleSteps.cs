using System;
using TechTalk.SpecFlow;

namespace TestAutomationFramework.Tests.Behaviordriven.Steps.Omdb
{
    [Binding]
    public class GetItemThroughTitleSteps
    {
        [Given(@"I have entered the title of the item")]
        public void GivenIHaveEnteredTheTitleOfTheItem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered that the type is a movie")]
        public void GivenIHaveEnteredThatTheTypeIsAMovie()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered that the type is a series")]
        public void GivenIHaveEnteredThatTheTypeIsASeries()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I connect to the API")]
        public void WhenIConnectToTheAPI()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the response should contain the movie title I searched for")]
        public void ThenTheResponseShouldContainTheMovieTitleISearchedFor()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the response should contain the series title I searched for")]
        public void ThenTheResponseShouldContainTheSeriesTitleISearchedFor()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
