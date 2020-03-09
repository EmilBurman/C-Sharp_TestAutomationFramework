using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTemplate.Framework.API.Services.Cat
{
    class CatServiceManager : ApiManagementInterface
    {
        static readonly string host = "https://cat-fact.herokuapp.com";
        public HttpResponse GetResponseFromUriAsHttpResponse(string uriToConnectThrough)
        {
            throw new NotImplementedException();
        }

        public string GetResponseFromUriAsJsonString(string uriToConnectThrough)
        {
            var restHost = new RestClient(host);
            var request = new RestRequest(uriToConnectThrough);
            String response = restHost.Get(request).Content;
            return response;
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
