using System.Net.Http;

namespace ZohoSubscriptions.Net.Requests {

    public class CancelZohoSubscription : ZohoSubscriptionsRequest<CancelZohoSubscription.Response> {

        public CancelZohoSubscription(string subscriptionId) : base("subscriptions/" + subscriptionId + "/cancel?cancel_at_end=true", HttpMethod.Post) {
        }

        public class Response : ZohoResponseMessage {
        }
    }
}