using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAPI.Framework.API.EndPoint
{
    public class Demo_EndPoints
    {
        /// <summary>
        /// Returns the Based URL for the Demo
        /// </summary>
        /// <returns></returns>
        public static string BasedURL() => "https://jsonplaceholder.typicode.com";

        /// <summary>
        /// Creates End Point for Demo URL
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static string GetEndPoint(string userId)
        {
            return "/users/" + userId;
        }
    }
}
