using System.Text.Json.Serialization;

namespace ZohoSubscriptions.Net.Models {
    public class ZohoInvoice {

        [JsonPropertyName("invoice_id")]
        public string Id { get; set; }
    }
}