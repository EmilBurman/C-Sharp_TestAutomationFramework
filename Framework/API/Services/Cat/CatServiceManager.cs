using RestSharp;
using System;

namespace TestAutomationFramework.Framework.API.Services.Cat
{
    class CatServiceManager : ApiManagementInterface
    {
        private string host = Properties.Resources.Cat_api_host;
        public RestResponse GetResponseFromUriAsRestResponse(string uriToConnectThrough) => Adapters.HttpAdapter.SendGetCall(host, uriToConnectThrough);

        public string GetResponseFromUriAsJsonString(string uriToConnectThrough) => Adapters.HttpAdapter.SendGetCall(host, uriToConnectThrough).Content;

        public string GetSpecificValueFromJsonResponse(string uriToConnectThrough, string jsonKey) => Adapters.HttpAdapter.CheckForJsonKeyInResponse(host, uriToConnectThrough, jsonKey, null);

        public string GetSpecificValueFromXmlResponse(string uriToConnectThrough, string xmlKey)
        {
            throw new NotImplementedException();
        }
    }
}
