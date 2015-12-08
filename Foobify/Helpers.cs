using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Foobify
{
    class Helpers
    {
        public static HttpClient createHTTPClient(String uri, List<HttpHeaders> headers, Boolean isAsync)
        {
            return createHTTPClient(new Uri(uri), headers, isAsync);
        }
        public static HttpClient createHTTPClient(Uri uri, List<HttpHeaders> headers, Boolean isAsync)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = uri;
            httpClient.DefaultRequestHeaders.Add("Accept", headers.ToString());
            return httpClient;
        }
    }
}
