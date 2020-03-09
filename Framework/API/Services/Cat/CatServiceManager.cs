using RestSharp;
using System;

namespace TestTemplate.Framework.API.Services.Cat
{
    class CatServiceManager : ApiManagementInterface
    {
        static readonly string host = "https://cat-fact.herokuapp.com";
        public RestResponse GetResponseFromUriAsRestResponse(string uriToConnectThrough)
        {
            return Adapters.HttpAdapter.SendGetCall(host,uriToConnectThrough);
        }

        public string GetResponseFromUriAsJsonString(string uriToConnectThrough) => Adapters.HttpAdapter.SendGetCall(host, uriToConnectThrough).Content;

        public string GetSpecificValueFromJsonResponse(string uriToConnectThrough, string jsonKey) => Adapters.HttpAdapter.CheckForJsonKeyInResponse(host, uriToConnectThrough, jsonKey, null);

        public string GetSpecificValueFromXmlResponse(string uriToConnectThrough, string xmlKey)
        {
            throw new NotImplementedException();
        }
    }
}
