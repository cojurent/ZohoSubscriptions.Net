using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {
    public class ReactivateZohoSubscription : ZohoSubscriptionsRequest<ReactivateZohoSubscription.Response> {
        
        public ReactivateZohoSubscription(string subscriptionId) : base("subscriptions/" + subscriptionId + "/reactivate", HttpMethod.Post) {
        }
        
        public class Response : ZohoResponseMessage {

            [JsonPropertyName("subscription")]
            public ZohoSubscription Subscription { get; set; }
        }
    }
}