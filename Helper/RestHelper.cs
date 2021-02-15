using System;
using RestSharp;
using System.Net;
using NUnit.Framework;

namespace DemoAPI.Framework.Helper
{
    /// <summary>
    /// Class to help setup Rest API calls.
    /// </summary>
    public class RestHelper
    {
        /// <summary>
        /// Stores Request Response
        /// </summary>
        public static IRestResponse response;

        /// <summary>
        /// Stores endpoint
        /// </summary>
        public static RestClient endPoint;

        /// <summary>
        /// Stores End Point
        /// </summary>
        public static RestRequest request = new RestRequest();

        /// <summary>
        /// This method will pull the URI together for the API Call
        /// </summary>
        /// <param name="baseURL"></param>
        /// <param name="endpointURL"></param>
        /// <returns></returns>
        public RestClient SetEndPoint(string fullUrl)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            RestClient endPoint = new RestClient(fullUrl);

            return endPoint;
        }

        public IRestResponse GetResponse(RestRequest restRequest, RestClient endpoint)
        {
            response = endpoint.Execute(restRequest);
            return response;
        }

        public RestRequest SetupRequestMethod(string requestUser,Method methodType)
        {
            if (methodType == Method.POST)
            {
                return new RestRequest(Method.POST);
            }

            if (methodType == Method.GET)
            {
                return new RestRequest(requestUser,Method.GET);
            }

            return new RestRequest(methodType);
        }

        /// <summary> 
        /// Asserts all Status Code returned from API
        /// </summary>
        /// <param name="response"></param>
        /// <param name="statusCode"></param>
        public static void AssertStatusCode(IRestResponse response, HttpStatusCode statusCode)
        {
            string statusCodeDescription = (string)response.StatusDescription;
            string updateDescription = statusCodeDescription.Replace(" ","");

            Assert.AreEqual(Convert.ToString(statusCode), updateDescription, "Status Code is " + updateDescription);
        }
    }
}
