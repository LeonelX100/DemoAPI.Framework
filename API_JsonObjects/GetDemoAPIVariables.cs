using Newtonsoft.Json;

namespace DemoAPI.Framework.API_JsonObjects
{
    public class GetDemoAPIVariables
    {
        public class user
        {
            [JsonProperty]
            public static string id { get; set; }
            [JsonProperty]
            public static string name { get; set; }
            [JsonProperty]
            public static string username { get; set; }
            [JsonProperty]
            public static string email { get; set; }

            public class address
            {
                [JsonProperty]
                public static string street { get; set; }
                [JsonProperty]
                public static string suite { get; set; }
                [JsonProperty]
                public static string city { get; set; }
                [JsonProperty]
                public static string zipcode { get; set; }

                public class geo
                {
                    [JsonProperty]
                    public static string lat { get; set; }
                    [JsonProperty]
                    public static string lng { get; set; }
                    [JsonProperty]
                    public static string phone { get; set; }
                    [JsonProperty]
                    public static string website { get; set; }
                }

                //public static geo geo { get; set; }
            }

            [JsonProperty]
            public static string phone { get; set; }
            [JsonProperty]
            public static string website { get; set; }

            public class company
            {
                [JsonProperty]
                public static string name { get; set; }
                [JsonProperty]
                public static string catchPhrase { get; set; }
                [JsonProperty]
                public static string bs { get; set; }
            }


        }  
    }
}
