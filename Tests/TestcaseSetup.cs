using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTemplate.Tests
{
    /* This class is run before any and all test cases.
     * It is used as a container of which everything else is run after.
     * If there is anything that needs to be done everytime, run it here.
     */
     
    [SetUpFixture]
    public class TestcaseSetup
    {
        [OneTimeSetUp]
        public void PreSuiteSetup()
        {
            Console.WriteLine("------ Test suite initiated ------");
            Console.WriteLine(DateTime.Now);
        }

        [OneTimeTearDown]
        public void PostSuiteTeardown()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("------ Test suite finished ------");
        }
    }
}
