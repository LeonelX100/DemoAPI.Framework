using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DemoAPI.Framework.API_JsonObjects
{
    public class DemoAPI_Response
    {

        public class UserResponse
        {
            [JsonProperty]
            public int id { get; set; }
            [JsonProperty]
            public string name { get; set; }
            [JsonProperty]
            public string username { get; set; }
            [JsonProperty]
            public string email { get; set; }
            [JsonProperty]
            public Address address { get; set; }
            [JsonProperty]
            public string phone { get; set; }
            [JsonProperty]
            public string website { get; set; }
            [JsonProperty]
            public Company company { get; set; }
        }

        public class Address
        {
            [JsonProperty]
            public string street { get; set; }
            [JsonProperty]
            public string suite { get; set; }
            [JsonProperty]
            public string city { get; set; }
            [JsonProperty]
            public string zipcode { get; set; }
            [JsonProperty]
            public Geo geo { get; set; }
        }

        public class Geo
        {
            [JsonProperty]
            public string lat { get; set; }
            [JsonProperty]
            public string lng { get; set; }
        }

        public class Company
        {
            [JsonProperty]
            public string name { get; set; }
            [JsonProperty]
            public string catchPhrase { get; set; }
            [JsonProperty]
            public string bs { get; set; }
        }

    }
}
