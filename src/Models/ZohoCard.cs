using System.Text.Json.Serialization;

namespace ZohoSubscriptions.Net.Models {
    public class ZohoCard {

        [JsonPropertyName("card_id")]
        public string Id { get; set; }

        [JsonPropertyName("expiry_month")]
        public int ExpirationMonth { get; set; }

        [JsonPropertyName("expiry_year")]
        public int ExpirationYear { get; set; }
    }
}
