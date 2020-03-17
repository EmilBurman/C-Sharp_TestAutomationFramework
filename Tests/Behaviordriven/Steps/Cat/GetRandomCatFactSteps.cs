using System;
using TechTalk.SpecFlow;

namespace TestAutomationFramework.Tests.Behaviordriven.Steps.Cat
{
    [Binding]
    public class GetRandomCatFactSteps
    {
        [Given(@"I have connected through the random endpoint")]
        public void GivenIHaveConnectedThroughTheRandomEndpoint()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I haven't entered a specfic ID")]
        public void GivenIHavenTEnteredASpecficID()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I recieve the response")]
        public void WhenIRecieveTheResponse()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should contain a random cat fact")]
        public void ThenTheResultShouldContainARandomCatFact()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
