using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {

    public class GetZohoSubscriptionSubscriptionsByCustomer : ZohoSubscriptionsRequest<GetZohoSubscriptionSubscriptionsByCustomer.Response> {
        
        public GetZohoSubscriptionSubscriptionsByCustomer(string customerId) : base("subscriptions?customer_id=" + customerId, HttpMethod.Get) {
        }
        
        public class Response : ZohoResponseMessage {

            [JsonPropertyName("subscriptions")]
            public List<ZohoSubscription> Subscriptions { get; set; }
        }
    }
}