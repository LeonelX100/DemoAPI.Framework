using System;
using System.Collections.Generic;
using System.Text;

using RestSharp;

namespace DemoAPI.Framework.StatusCode
{
    /// <summary>
    /// A Class used for context Innjections for the API Responses
    /// </summary>
    public class ApiContent
    {
        /// <summary>
        /// Thent Content return from API
        /// </summary>
        public object Content;

        /// <summary>
        /// The full response returned from the API.
        /// </summary>
        public IRestResponse Response;

    }
}
