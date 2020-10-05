using ExchangeRateApiCall.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ExchangeRateApiCall.Controllers
{
    class ExchangeRateController
    {
        HttpServer http;
        ExchangeRateView erv;
        public ExchangeRateController()
        {
            http = new HttpServer();
        }

        public void getExchangeRates()
        {
            ExchangeRatesObject obj = JsonConvert.DeserializeObject<ExchangeRatesObject>(http.SendGetRequest("https://api.exchangeratesapi.io", "latest"));
            erv = new ExchangeRateView(obj);
            erv.outputToConsole();
        }
    }
}
