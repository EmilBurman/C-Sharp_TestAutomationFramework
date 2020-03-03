using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTemplate.Tests.API
{
    [TestFixture]
    abstract public class AbstractApiTestcase
    {
        [SetUp]
        public void checkLiveness()
        {
            Assert.Pass();
        }
    }
}
