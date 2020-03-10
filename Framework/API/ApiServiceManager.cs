using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationFramework.Framework.API.Services.Cat;
using TestAutomationFramework.Framework.API.Services.Omdb;
using TestAutomationFramework.Framework.API.Services.Misc;

namespace TestAutomationFramework.Framework.API
{
    class ApiServiceManager
    {
        public static String GetResponseFromUriAsJsonString(AvailableApiServices requestedApiHost, String uriToConnectThrough)
        {
            ApiManagementInterface apiHost = apiFactory(requestedApiHost);
            return apiHost.GetResponseFromUriAsJsonString(uriToConnectThrough);
        }

        public static String GetSpecificValueFromJsonResponse(AvailableApiServices requestedApiHost, String uriToConnectThrough, String jsonKey)
        {
            ApiManagementInterface apiHost = apiFactory(requestedApiHost);
            return apiHost.GetSpecificValueFromJsonResponse(uriToConnectThrough, jsonKey);
        }

        public static String GetSpecificValueFromXmlResponse(AvailableApiServices requestedApiHost, String uriToConnectThrough, String xmlKey)
        {
            ApiManagementInterface apiHost = apiFactory(requestedApiHost);
            return apiHost.GetSpecificValueFromXmlResponse(uriToConnectThrough, xmlKey);
        }

        public static RestResponse GetResponseFromUriAsRestResponse(AvailableApiServices requestedApiHost, String uriToConnectThrough)
        {
            ApiManagementInterface apiHost = apiFactory(requestedApiHost);
            return apiHost.GetResponseFromUriAsRestResponse(uriToConnectThrough);
        }

        private static ApiManagementInterface apiFactory(AvailableApiServices requestedApi)
        {
            switch (requestedApi)
            {
                case AvailableApiServices.CAT:
                    return new CatServiceManager();
                case AvailableApiServices.OMDB:
                    return new OmdbServiceManger();
                default:
                    throw new FormatException("Requested API is not available. Please check configuration.");
            }
        }
    }
}
