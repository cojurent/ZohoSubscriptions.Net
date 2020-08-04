using System.Text.Json.Serialization;

namespace ZohoSubscriptions.Net.Models {
    public class ZohoInvoiceItem {

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("price")]
        public float Price { get; set; }
    }
}