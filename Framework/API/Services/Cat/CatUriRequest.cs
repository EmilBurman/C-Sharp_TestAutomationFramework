using System;
using System.Linq;

namespace TestTemplate.Framework.API.Services.Cat
{
    class CatUriRequest: UriRequest
    {
        bool searchUsers = false;
        bool useRandom = true;
        private string id;

        /*
        Everything below here is used to create the URI used to connect to the API.
        If the API changes, please adjust the variables below in order to facilitate the change.
        */

        public override String ToString()
        {
            string endpoint = CreateEndpointFromVariables();
            string uri = string.Join("&",
                                     uriDictionary.Select(x => x.Key + "=" + x.Value));
            Console.WriteLine("URI used for the cat request: " + uri);
            return (endpoint + uri);
        }

        private String CreateEndpointFromVariables()
        {
            string endpoint = "/facts";
            if (searchUsers)
            {
                endpoint = "/users";
            }

            if (!(id == null))
            {
                return endpoint + "/" + id;
            }
            else
            {
                if (!searchUsers && useRandom)
                {
                    endpoint += "/random";
                }
                if (uriDictionary.Count < 1)
                {
                    endpoint += "/";
                }
                else
                {
                    endpoint += "?";
                }
                return endpoint;
            }
        }

        public CatUriRequest(CatRequestBuilder builder)
        {
            this.id = builder.id;
            this.searchUsers = builder.searchUsers;
            this.useRandom = builder.useRandom;
            this.uriDictionary = builder.getUriDictionary();
        }

        public class CatRequestBuilder : UriRequest
        {
            public string id;
            public  bool searchUsers = false;
            public  bool useRandom = false;


            public CatRequestBuilder()
            {
            }

            public CatRequestBuilder UsingAnimalType(String animalType)
            {
                addToDictionary("animal_type", animalType);
                return this;
            }

            public CatRequestBuilder WithAmount(int amount)
            {
                addToDictionary("amount", amount.ToString());
                return this;
            }

            public CatRequestBuilder UsingID(String id)
            {
                this.id = id;
                return this;
            }

            public CatRequestBuilder GetRandom()
            {
                this.useRandom = true;
                return this;
            }

            public CatRequestBuilder SearchByUser(Boolean useUser)
            {
                this.searchUsers = useUser;
                this.useRandom = false;
                return this;
            }
            public CatUriRequest Build()
            {
                return new CatUriRequest(this);
            }
    }
}
}
