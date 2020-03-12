using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationFramework.Tests.API
{
    [TestFixture]
    abstract public class AbstractApiTestcase: TestcaseSetup
    {
        [SetUp]
        public void checkLiveness()
        {
            Console.WriteLine();
        }
    }
}
