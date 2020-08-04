using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {
    public class CreateZohoCustomer : ZohoSubscriptionsRequest<CreateZohoCustomer.Response> {

        public CreateZohoCustomer()
            : base($"customers", HttpMethod.Post) {

            CustomFields = new List<ZohoCustomField>();
        }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("custom_fields")]
        public List<ZohoCustomField> CustomFields { get; set; }
        
        
        public class Response : ZohoResponseMessage {
            
            [JsonPropertyName("customer")]
            public ZohoCustomer Customer { get; set; }
        }
    }
}