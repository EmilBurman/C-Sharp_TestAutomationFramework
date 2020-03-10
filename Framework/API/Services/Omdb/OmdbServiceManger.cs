using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTemplate.Framework.API.Services.Omdb
{   
    class OmdbServiceManger : ApiManagementInterface
    {
        static readonly string host = "http://www.omdbapi.com";
        static readonly string apikey = "&apikey=" + "25f61fa0";
        public RestResponse GetResponseFromUriAsRestResponse(string uriToConnectThrough) => Adapters.HttpAdapter.SendGetCall(host, uriToConnectThrough + apikey);

        public string GetResponseFromUriAsJsonString(string uriToConnectThrough) => Adapters.HttpAdapter.SendGetCall(host, uriToConnectThrough+apikey).Content;

        public string GetSpecificValueFromJsonResponse(string uriToConnectThrough, string jsonKey) => Adapters.HttpAdapter.CheckForJsonKeyInResponse(host, uriToConnectThrough, jsonKey, apikey);


        public string GetSpecificValueFromXmlResponse(string uriToConnectThrough, string xmlKey)
        {
            throw new NotImplementedException();
        }
    }
}
