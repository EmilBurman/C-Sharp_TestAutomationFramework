using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationFramework.Framework.API
{
    interface ApiManagementInterface
    {
        String GetResponseFromUriAsJsonString(String uriToConnectThrough);

        String GetSpecificValueFromJsonResponse(String uriToConnectThrough, String jsonKey);

        String GetSpecificValueFromXmlResponse(String uriToConnectThrough, String xmlKey);

        RestResponse GetResponseFromUriAsRestResponse(String uriToConnectThrough);
    }
}
