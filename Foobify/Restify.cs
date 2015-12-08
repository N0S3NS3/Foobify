using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Foobify
{
    // Restify is a simple REST based interface for Spotify communication
    class Restify : IRestify
    {
        public string restAuthentication { get; private set; }
        public Uri restUrl { get; private set; }
        public verb restVerb { get; private set; }
        public Boolean connectionState { get; private set; }
        private HttpClient restClient { get; set; }

        public enum verb { GET, POST, PUT, DELETE };

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
