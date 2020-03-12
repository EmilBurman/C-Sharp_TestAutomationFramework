using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationFramework.Framework.API
{
    interface ApiManagementInterface
    {
        string GetResponseFromUriAsJsonString(string uriToConnectThrough);

        string GetSpecificValueFromJsonResponse(string uriToConnectThrough, string jsonKey);

        string GetSpecificValueFromXmlResponse(string uriToConnectThrough, string xmlKey);

        RestResponse GetResponseFromUriAsRestResponse(string uriToConnectThrough);
    }
}
