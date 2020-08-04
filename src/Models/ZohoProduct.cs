using System.Text.Json.Serialization;

namespace ZohoSubscriptions.Net.Models {
    public class ZohoProduct {

        [JsonPropertyName("product_id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}