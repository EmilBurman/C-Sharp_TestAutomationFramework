using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationFramework.Framework.API;
using TestAutomationFramework.Framework.API.Services.Misc;
using TestAutomationFramework.Framework.API.Services.Omdb;
using TestAutomationFramework.Tests.Tags;

namespace TestAutomationFramework.Tests.API.Services.Omdb
{
    [TestOf(TestcaseTags.API)]
    [TestOf(TestcaseTags.API_OMDB)]
    [Category(TestcaseTags.API)]
    class T_getId_json : AbstractApiTestcase
    {
        [Test, TestCaseSource("SearchId")]
        public void validateSpecificItem(string id)
        {
            string uriReq = new OmdbUriRequest.OmdbRequestBuilder(OmdbTerms.ID, id)
                    .Build()
                    .ToString();
            string request = ApiServiceManager.GetSpecificValueFromJsonResponse(AvailableApiServices.OMDB, uriReq, "imdbID");
            Assert.IsTrue(request.ToLower().Contains(id.ToLower()));
        }
        private static IEnumerable<TestCaseData> SearchId()
        {
            yield return new TestCaseData("tt0087544");

        }
    }
}
