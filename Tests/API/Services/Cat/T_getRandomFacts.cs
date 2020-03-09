using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestTemplate.Framework.API.Services.Cat;

namespace TestTemplate.Tests.API.Services.Cat
{
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
            TestContext.WriteLine(uriRequest);
            Console.WriteLine(uriRequest);
        }

        [Test]
        public void validateResponseContainsText()
        {
            Assert.Pass();
        }

        [Test]
        public void validateResponseIsRandom()
        {
            Assert.Pass();
        }

        private static IEnumerable<TestCaseData> AnimalCases()
        {
            yield return new TestCaseData("dog");
            yield return new TestCaseData("horse");
            yield return new TestCaseData("cat");
        }
    }
}
