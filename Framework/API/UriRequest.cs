using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TestAutomationFramework.Framework.API
{
    public class UriRequest
    {
        protected Dictionary<String, String> uriDictionary = new Dictionary<String, String>();

        public UriRequest()
        {
        }

        public UriRequest addToDictionary(String key, String value)
        {
            this.uriDictionary.Add(key, convertStringToUriSafeString(value));
            return this;
        }

        public Dictionary<String, String> getUriDictionary()
        {
            return this.uriDictionary;
        }

        public override string ToString()
        {
            string uri = ("/?" + string.Join("&", uriDictionary.Select(x => x.Key + "=" + x.Value)));
            Console.WriteLine("Uri used for the request: " + uri);
            return uri;
        }

        public String convertStringToUriSafeString(String initalString)
        {
            String convertedString = "";
            convertedString = HttpUtility.UrlEncode(initalString);
            return convertedString;
        }
    }
}
