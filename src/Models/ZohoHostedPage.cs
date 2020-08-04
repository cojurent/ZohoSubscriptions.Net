using System.Text.Json.Serialization;

namespace ZohoSubscriptions.Net.Models {
    public class ZohoHostedPage {

        [JsonPropertyName("hostedpage_id")]
        public string Id { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; }
    }
}
