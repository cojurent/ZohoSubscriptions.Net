using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {

    public class GetZohoHostedSubscriptionPage : ZohoSubscriptionsRequest<GetZohoHostedSubscriptionPage.Response> {
        
        public GetZohoHostedSubscriptionPage(bool isNew) : base("hostedpages/" + (isNew ? "newsubscription" : "updatesubscription"), HttpMethod.Post) {
        }

        [JsonPropertyName("customer_id")]
        public string CustomerId { get; set; }

        [JsonPropertyName("subscription_id")]
        public string SubscriptionId { get; set; }

        [JsonPropertyName("plan")]
        public ZohoPlan Plan { get; set; }

        [JsonPropertyName("addons")]
        public List<ZohoAddon> Addons { get; set; }
        
        public class Response : ZohoResponseMessage {

            [JsonPropertyName("hostedpage")]
            public ZohoHostedPage Page { get; set; }
        }
    }
}