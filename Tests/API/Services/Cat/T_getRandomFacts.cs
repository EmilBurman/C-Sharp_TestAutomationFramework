using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestAutomationFramework.Framework.API;
using TestAutomationFramework.Framework.API.Services.Cat;
using TestAutomationFramework.Framework.API.Services.Misc;
using TestAutomationFramework.Properties;
using TestAutomationFramework.Tests.Tags;

namespace TestAutomationFramework.Tests.API.Services.Cat
{
    [TestOf({TestcaseTags.API)]
    [TestOf({TestcaseTags.API_CAT)]
    public class GetRandomFacts : AbstractApiTestcase
    {
        private string uriRequest;
        [Test, TestCaseSource("AnimalCases")]
        public void CheckIfAnimalTypeExists(string animalType)
        {
            uriRequest = new CatUriRequest.CatRequestBuilder().GetRandom()
                                                                     .UsingAnimalType(animalType)
                                                                     .Build()
                                                                     .ToString();
            string request = ApiServiceManager.GetResponseFromUriAsJsonString(AvailableApiServices.CAT,
                                                                              uriRequest);
            Console.WriteLine(uriRequest + request);
            Assert.IsNotNull(request);
        }

        [Test, TestCaseSource("SpecificId")]
        public void ValidateEntireObject(string factID)
        {
            uriRequest = new CatUriRequest.CatRequestBuilder()
                    .UsingID(factID)
                    .Build()
                    .ToString();
            string responseAsJson = ApiServiceManager.GetResponseFromUriAsJsonString(AvailableApiServices.CAT, uriRequest);
            Console.WriteLine(responseAsJson);
            Assert.IsNotNull(responseAsJson);
        }

        [Test, TestCaseSource("SpecificIdAndFacts")]
        public void ValidateTextInResponse(string factID, string text)
        {
            uriRequest = new CatUriRequest.CatRequestBuilder()
                    .UsingID(factID)
                    .Build()
                    .ToString();
            string responseAsJson = ApiServiceManager.GetSpecificValueFromJsonResponse(AvailableApiServices.CAT, uriRequest, "text");
            Assert.IsTrue(responseAsJson.ToLower().Contains(text.ToLower()));
        }

        private static IEnumerable<TestCaseData> AnimalCases()
        {
            yield return new TestCaseData("dog");
            yield return new TestCaseData("horse");
            yield return new TestCaseData("cat");
        }

        private static IEnumerable<TestCaseData> SpecificId()
        {
            yield return new TestCaseData("591f98883b90f7150a19c28c");
        }

        private static IEnumerable<TestCaseData> SpecificIdAndFacts()
        {
            yield return new TestCaseData("591f98883b90f7150a19c28c", "Cats lived with soldiers in trenches, where they killed mice during World War I.");
            yield return new TestCaseData("591f98703b90f7150a19c14f", "Unlike humans, cats do not need to blink their eyes on a regular basis to keep their eyes lubricated.");

        }
    }
}
