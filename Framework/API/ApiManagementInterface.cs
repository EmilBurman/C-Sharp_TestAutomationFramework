using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTemplate.Framework.API
{
    interface ApiManagementInterface
    {
        String getResponseFromUriAsJsonString(String uriToConnectThrough);

        String getSpecificValueFromJsonResponse(String uriToConnectThrough, String jsonKey);

        String getSpecificValueFromXmlResponse(String uriToConnectThrough, String xmlKey);

        HttpResponse getResponseFromUriAsHttpResponse(String uriToConnectThrough);
    }
}
