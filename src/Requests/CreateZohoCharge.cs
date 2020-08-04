using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {
    public class CreateZohoCharge : ZohoSubscriptionsRequest<CreateZohoCharge.Response> {

        public CreateZohoCharge(string subscriptionId)
            : base($"subscriptions/{subscriptionId}/charge", HttpMethod.Post) {
        }

        [JsonPropertyName("amount")]
        public float Amount { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
        
        public class Response : ZohoResponseMessage {

            [JsonPropertyName("subscription")]
            public ZohoSubscription Subscription { get; set; }

            [JsonPropertyName("invoice")]
            public ZohoInvoice Invoice { get; set; }
        }
    }
}