using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {
    public class CreateZohoSubscription : ZohoSubscriptionsRequest<CreateZohoSubscription.Response> {

        public CreateZohoSubscription()
            : base("subscriptions", HttpMethod.Post) {
        }

        [JsonPropertyName("customer_id")]
        public string CustomerId { get; set; }

        [JsonPropertyName("starts_at")]
        public string StartDate { get; set; }

        [JsonPropertyName("plan")]
        public ZohoPlan Plan { get; set; }

        [JsonPropertyName("create_backdated_invoice")]
        public bool IsBackdated { get; set; }

        [JsonPropertyName("auto_collect")]
        public bool AutoCollect { get; set; }

        [JsonPropertyName("end_of_term")]
        public bool EndOfTerm { get; set; }

        [JsonPropertyName("payment_gateway")]
        public string PaymentGateway { get; set; }
        
        public class Response : ZohoResponseMessage {

            [JsonPropertyName("subscription")]
            public ZohoSubscription Subscription { get; set; }
        }
    }
}