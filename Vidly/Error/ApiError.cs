using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Error
{
    public class ApiError
    {
        public int StatusCode { get; private set; }

        public string StatusDescription { get; private set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Message { get; private set; }

        public ApiError(int statusCode, string statusDescription)
        {
            this.StatusCode = statusCode;
            this.StatusDescription = statusDescription;
        }

        public ApiError(int statusCode, string statusDescription, string message)
            : this(statusCode, statusDescription)
        {
            this.Message = message ?? GetDefaultMessageForStatusCode(statusCode);

        }

        private static string GetDefaultMessageForStatusCode(int statusCode)
        {
            switch (statusCode)
            {
            
            case 404:
                return "Resource not found";
            case 500:
                return "An unhandled error occurred";
            default:
                return null;
        }
    }
}
}