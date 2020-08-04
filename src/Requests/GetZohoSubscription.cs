using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {

    public class GetZohoSubscription : ZohoSubscriptionsRequest<GetZohoSubscription.Response> {
        
        public GetZohoSubscription(string subscriptionId) : base("subscription/" + subscriptionId, HttpMethod.Get) {
        }
        
        public class Response : ZohoResponseMessage {

            [JsonPropertyName("subscription")]
            public ZohoSubscription Subscription { get; set; }
        }
    }
}