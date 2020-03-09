using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTemplate.Framework.Adapters
{
    class HttpAdapter
    {
        public static RestResponse SendGetCall(string host, string uri)
        {
            RestClient restHost = new RestClient(host);
            RestRequest request = new RestRequest(uri);
            return (RestResponse) restHost.Get(request);
        }

        public static String CheckForJsonKeyInResponse(string host, string uri, string jsonKey, string apiKey)
        {
            if (apiKey == null)
            {
                apiKey = "";
            }

            RestResponse response = SendGetCall(host,uri+apiKey);
            Console.WriteLine(response);
            JObject responseObjectAsJson = JObject.Parse(response.Content);
            Console.WriteLine(responseObjectAsJson);
            //Extracting Node element using Getvalue method
            string jsonKeyValue = responseObjectAsJson.GetValue(jsonKey).ToString();
            Console.WriteLine(jsonKeyValue);
            return jsonKeyValue;
        }
    }
}
