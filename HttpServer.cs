using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serialization.Json;

namespace ExchangeRateApiCall
{
    class HttpServer
    {
        RestClient HttpClient;

        public string SendGetRequest(string host, string path, string username = null, string password = null)
        {
            HttpClient = new RestClient(host);
            
            if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password))
            {
                HttpClient.Authenticator = new HttpBasicAuthenticator(username, password);
            }
            var request = new RestRequest(path, DataFormat.Json);
            var response = HttpClient.Execute(request);
            return response.Content;
        }
    }
}
