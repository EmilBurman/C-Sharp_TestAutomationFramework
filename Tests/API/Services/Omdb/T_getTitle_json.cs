using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestTemplate.Framework.API;
using TestTemplate.Framework.API.Services.Misc;
using TestTemplate.Framework.API.Services.Omdb;

namespace TestTemplate.Tests.API.Services.Omdb
{
    class T_getTitle_json
    {
        [Test, TestCaseSource("MovieTitles")]
        public void ValidateMovieExists(String title)
        {
            String uriRequest = new OmdbUriRequest.OmdbRequestBuilder(OmdbApiTerms.TITLE, title)
                    .UsingFormat(OmdbApiTerms.MOVIE)
                    .UsingDatatype(OmdbApiTerms.JSON_DATATYPE)
                    .WithPlotType(OmdbApiTerms.SHORT_PLOT)
                    .WithPageNumber(1)
                    .Build()
                    .ToString();
            // Make request and get the answer as a JSON string
            String request = ApiServiceManager.GetSpecificValueFromJsonResponse(AvailableApiServices.OMDB, uriRequest, "Title");
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
            String uriRequest = new OmdbUriRequest.OmdbRequestBuilder(OmdbApiTerms.TITLE, title)
                    .UsingFormat(OmdbApiTerms.SERIES)
                    .UsingDatatype(OmdbApiTerms.JSON_DATATYPE)
                    .WithPlotType(OmdbApiTerms.FULL_PLOT)
                    .WithPageNumber(1)
                    .Build()
                    .ToString();
            // Make request and get the answer as a JSON string
            String request = ApiServiceManager.GetSpecificValueFromJsonResponse(AvailableApiServices.OMDB, uriRequest, "Title");
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
