using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTemplate.Framework.API.Services.Omdb
{
    class OmdbServiceManger : ApiManagementInterface
    {
        public HttpResponse GetResponseFromUriAsHttpResponse(string uriToConnectThrough)
        {
            throw new NotImplementedException();
        }

        public string GetResponseFromUriAsJsonString(string uriToConnectThrough)
        {
            throw new NotImplementedException();
        }

        public string GetSpecificValueFromJsonResponse(string uriToConnectThrough, string jsonKey)
        {
            throw new NotImplementedException();
        }

        public string GetSpecificValueFromXmlResponse(string uriToConnectThrough, string xmlKey)
        {
            throw new NotImplementedException();
        }
    }
}
