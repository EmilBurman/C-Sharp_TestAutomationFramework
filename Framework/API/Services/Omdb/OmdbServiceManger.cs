using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationFramework.Framework.API.Services.Omdb
{   
    class OmdbServiceManger : ApiManagementInterface
    {
        static readonly string host = Properties.Resources.Omdb_api_host;
        static readonly string apikey = "&apikey=" + Properties.Resources.Omdb_api_key;
        public RestResponse GetResponseFromUriAsRestResponse(string uriToConnectThrough) => Adapters.HttpAdapter.SendGetCall(host, uriToConnectThrough + apikey);

        public string GetResponseFromUriAsJsonString(string uriToConnectThrough) => Adapters.HttpAdapter.SendGetCall(host, uriToConnectThrough+apikey).Content;

        public string GetSpecificValueFromJsonResponse(string uriToConnectThrough, string jsonKey) => Adapters.HttpAdapter.CheckForJsonKeyInResponse(host, uriToConnectThrough, jsonKey, apikey);


        public string GetSpecificValueFromXmlResponse(string uriToConnectThrough, string xmlKey)
        {
            throw new NotImplementedException();
        }
    }
}
