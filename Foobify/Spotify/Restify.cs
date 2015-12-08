using System;
using System.Collections.Generic;
using System.Net.Http;
using Foobify;

namespace Spotify
{
    // Restify is a simple REST based interface for Spotify communication
    class Restify : IRestify
    {
        protected static Dictionary<int, httpResponse> ResponseCodes = new Dictionary<int, httpResponse>()
        {
            { 200, new httpResponse(true, "OK") },
            { 201, new httpResponse(true, "Created") },
            { 204, new httpResponse(true, "No Content") },
            { 304, new httpResponse(true, "Not Modified") },
            { 400, new httpResponse(false, "Bad Request") },
            { 401, new httpResponse(false, "Unauthorized") },
            { 403, new httpResponse(false, "Forbidden") },
            { 404, new httpResponse(false, "Not Found") },
            { 429, new httpResponse(false, "Too Many Request") },
            { 500, new httpResponse(false, "Internal Server Error") },
            { 502, new httpResponse(false, "Bad Gateway") },
            { 503, new httpResponse(false, "Service Unavailable") }
        };
        protected struct httpResponse
        {
            public bool isSuccess { get; private set; }
            public string description { get; private set; }
            public httpResponse(bool isSuccess, string description)
            {
                this.isSuccess = isSuccess; 
                this.description = description;
            }
        }

        public string restAuthentication { get; private set; }
        public Uri restUrl { get; private set; }
        public verb restVerb { get; private set; }
        public bool connectionState { get; private set; }
        private HttpClient restClient { get; set; }

        public enum verb { GET, POST, PUT, DELETE };

        private KeyValuePair<int, httpResponse> currentResponseState { get; set; }
        public int getResponseCode { get { return this.currentResponseState.Key; } }
        public bool getResponseState { get { return this.currentResponseState.Value.isSuccess; } }
        public string getResponseValue { get { return this.currentResponseState.Value.description; } }

        public Restify() { }

        public Restify(Uri restUrl, verb restVerb, string restAuthentication)
        {
            this.restUrl = restUrl;
            this.restVerb = restVerb;
            this.restAuthentication = restAuthentication;
            this.restClient = Helpers.createHTTPClient(this.restUrl, null, false);
            this.connectionState = this.testConnection();
        }

        private Boolean testConnection()
        {
            return false;
        }

        public void connect()
        {
            
        }
        public void disconnect()
        {

        }
        public Boolean checkAuthentication()
        {
            return false;
        }
    }
}
