using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Transactions;

namespace ExchangeRateApiCall
{
    class ExchangeRatesObject
    {
        public Dictionary<string, double> rates { get; set; }
        [JsonProperty("base")]
        public string baseRate { get; set; }
        public DateTime date { get; set; }
    }
}
