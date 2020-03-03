using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTemplate.Tests.API.Services.Cat
{
    public class GetRandomFacts : AbstractApiTestcase
    {
        [Test]
        public void validateResponseMatchesHttpcode()
        {
            Assert.Pass();
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
    }
}
