using System;
using System.Collections.Generic;
using System.Text;

namespace TestTemplate.Framework.API.Services.Omdb
{
    class OmdbUriRequest: UriRequest
    {
        public OmdbUriRequest(OmdbRequestBuilder builder)
        {
            this.uriDictionary = builder.getUriDictionary();
        }

        public class OmdbRequestBuilder: UriRequest
        {

        public OmdbRequestBuilder(string searchType, string searchTerm)
        {
            addToDictionary(searchType, searchTerm);
        }

        public OmdbRequestBuilder UsingFormat(string entertainmentFormat)
        {
            addToDictionary("type", entertainmentFormat);
            return this;
        }

        public OmdbRequestBuilder UsingYear(string year)
        {
            addToDictionary("y", year);
            return this;
        }

        public OmdbRequestBuilder WithPlotType(string plotType)
        {
            addToDictionary("plot", plotType);
            return this;
        }

        public OmdbRequestBuilder WithPageNumber(int page)
        {
            addToDictionary("page", page.ToString());
            return this;
        }

        public OmdbRequestBuilder UsingDatatype(string datatype)
        {
            addToDictionary("r", datatype);
            return this;
        }

        public OmdbUriRequest Build()
        {
            return new OmdbUriRequest(this);
        }
    }
}
}
