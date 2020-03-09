using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTemplate.Framework.API.Services.Cat
{
    class CatServiceManager : ApiManagementInterface
    {
        public HttpResponse getResponseFromUriAsHttpResponse(string uriToConnectThrough)
        {
            throw new NotImplementedException();
        }

        public string getResponseFromUriAsJsonString(string uriToConnectThrough)
        {
            throw new NotImplementedException();
        }

        public string getSpecificValueFromJsonResponse(string uriToConnectThrough, string jsonKey)
        {
            throw new NotImplementedException();
        }

        public string getSpecificValueFromXmlResponse(string uriToConnectThrough, string xmlKey)
        {
            throw new NotImplementedException();
        }
    }
}
