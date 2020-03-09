using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTemplate.Framework.API
{
    interface ApiManagementInterface
    {
        String GetResponseFromUriAsJsonString(String uriToConnectThrough);

        String GetSpecificValueFromJsonResponse(String uriToConnectThrough, String jsonKey);

        String GetSpecificValueFromXmlResponse(String uriToConnectThrough, String xmlKey);

        RestResponse GetResponseFromUriAsRestResponse(String uriToConnectThrough);
    }
}
