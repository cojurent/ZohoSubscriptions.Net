using System;
using System.Text.Json.Serialization;

namespace ZohoSubscriptions.Net.Models {

    public class ZohoSubscription {

        public ZohoSubscriptionStatusTypes GetStatus() {

            switch(Status) {
                
                case "active":
                    return ZohoSubscriptionStatusTypes.Active;
                
                case "live":
                    return ZohoSubscriptionStatusTypes.Live;
                
                case "future":
                    return ZohoSubscriptionStatusTypes.Future;
                
                case "trial":
                    return ZohoSubscriptionStatusTypes.Trial;

                case "non_renewing":
                    return ZohoSubscriptionStatusTypes.NonRenewing;
            }

            return ZohoSubscriptionStatusTypes.Unknown;
        }

        [JsonPropertyName("subscription_id")]
        public string Id { get; set; }

        [JsonPropertyName("customer_id")]
        public string CustomerId { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("child_invoice_id")]
        public string InvoiceId { get; set; }

        [JsonPropertyName("last_billing_at")]
        public DateTime? LastBillingAt { get; set; }

        [JsonPropertyName("next_billing_at")]
        public DateTime? NextBillingAt { get; set; }

        [JsonPropertyName("interval_unit")]
        public string IntervalUnit { get; set; }

        [JsonPropertyName("current_term_ends_at")]
        public DateTime? CurrentTermEndsAt { get; set; }

        [JsonPropertyName("plan")]
        public ZohoPlan Plan { get; set; }

        [JsonPropertyName("plan_code")]
        public string PlanCode { get; set; }

        [JsonPropertyName("amount")]
        public float Amount { get; set; }

        [JsonPropertyName("plan_name")]
        public string PlanName { get; set; }

        [JsonPropertyName("customer")]
        public ZohoCustomer Customer { get; set; }
    }
}