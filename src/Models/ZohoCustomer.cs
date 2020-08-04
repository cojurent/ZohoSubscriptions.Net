using System.Text.Json.Serialization;

namespace ZohoSubscriptions.Net.Models {

    public class ZohoCustomer {

        [JsonPropertyName("customer_id")]
        public string Id { get; set; }
        
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}