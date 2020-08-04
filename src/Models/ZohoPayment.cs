using System;
using System.Text.Json.Serialization;

namespace ZohoSubscriptions.Net.Models {

    public class ZohoPayment {

        [JsonPropertyName("payment_id")]
        public string Id { get; set; }

        [JsonPropertyName("amount")]
        public float Amount { get; set; }

        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
    }
}