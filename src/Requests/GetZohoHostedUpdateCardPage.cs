using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {

    public class GetZohoHostedUpdateCardPage : ZohoSubscriptionsRequest<GetZohoHostedSubscriptionPage.Response> {
        
        public GetZohoHostedUpdateCardPage() : base("hostedpages/updatecard", HttpMethod.Post) {
        }

        [JsonPropertyName("subscription_id")]
        public string SubscriptionId { get; set; }

        public class Response : ZohoResponseMessage {

            [JsonPropertyName("hostedpage")]
            public ZohoHostedPage Page { get; set; }
        }
    }
}