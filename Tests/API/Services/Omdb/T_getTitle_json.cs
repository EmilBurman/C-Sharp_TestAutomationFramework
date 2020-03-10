using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationFramework.Framework.API;
using TestAutomationFramework.Framework.API.Services.Misc;
using TestAutomationFramework.Framework.API.Services.Omdb;

namespace TestAutomationFramework.Tests.API.Services.Omdb
{
    class T_getTitle_json : AbstractApiTestcase
    {
        [Test, TestCaseSource("MovieTitles")]
        public void ValidateMovieExists(String title)
        {
            String uriRequest = new OmdbUriRequest.OmdbRequestBuilder(OmdbTerms.TITLE, title)
                    .UsingFormat(OmdbTerms.MOVIES)
                    .UsingDatatype(OmdbTerms.JSON_DATATYPE)
                    .WithPlotType(OmdbTerms.SHORT_PLOT)
                    .WithPageNumber(1)
                    .Build()
                    .ToString();
            // Make request and get the answer as a JSON string
            string request = ApiServiceManager.GetSpecificValueFromJsonResponse(AvailableApiServices.OMDB, uriRequest, "Title");
            //Make sure the title matches the expected value
            Assert.IsTrue(request.Contains(title));
        }

        private static IEnumerable<TestCaseData> MovieTitles()
        {
            yield return new TestCaseData("Shawshank");
            yield return new TestCaseData("Spiderman");
            yield return new TestCaseData("Nausicaa of the Valley of the Wind");
        }

        [Test, TestCaseSource("SeriesTitles")]
        public void ValidateSeriesExists(String title)
        {
            String uriRequest = new OmdbUriRequest.OmdbRequestBuilder(OmdbTerms.TITLE, title)
                    .UsingFormat(OmdbTerms.SERIES)
                    .UsingDatatype(OmdbTerms.JSON_DATATYPE)
                    .WithPlotType(OmdbTerms.FULL_PLOT)
                    .WithPageNumber(1)
                    .Build()
                    .ToString();
            // Make request and get the answer as a JSON string
            string request = ApiServiceManager.GetSpecificValueFromJsonResponse(AvailableApiServices.OMDB, uriRequest, "Title");
            //Make sure the title matches the expected value
            Assert.IsTrue(request.ToLower().Contains(title.ToLower()));
        }

        private static IEnumerable<TestCaseData> SeriesTitles()
        {
            yield return new TestCaseData("Game of Thrones");
            yield return new TestCaseData("Bojack Horseman");
            yield return new TestCaseData("Forged in Fire");
        }
    }
}
