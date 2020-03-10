using RestSharp;
using System;

namespace TestAutomationFramework.Framework.API.Services.Twitter
{
    class TwitterServiceManager : ApiManagementInterface
    {
        public RestResponse GetResponseFromUriAsRestResponse(string uriToConnectThrough)
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
