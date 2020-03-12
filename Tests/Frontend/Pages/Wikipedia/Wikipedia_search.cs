using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationFramework.Framework.Frontend.Pages.Wikipedia;

namespace TestAutomationFramework.Tests.Frontend.Pages.Wikipedia
{
    class Wikipedia_search: AbstractFrontendTestcase
    {
        [Test, TestCaseSource("WikipediaTerms")]
        public void Wikipedia_searchForTerm(string term)
        {
            // TODO: Add your test code here
            Wikipedia_startpage wikipedia_start = new Wikipedia_startpage(this.DriverContext);
            wikipedia_start.Open();
            wikipedia_start.SearchForTerm(term);
            Wikipedia_contentpage wikipedia_content = new Wikipedia_contentpage(this.DriverContext);
            wikipedia_content.CheckIfFirstHeadingMatchesTerm(term);
        }

        private static IEnumerable<TestCaseData> WikipediaTerms()
        {
            yield return new TestCaseData("banana");
            yield return new TestCaseData("pineapple");
            yield return new TestCaseData("pancake");
        }
    }
}
