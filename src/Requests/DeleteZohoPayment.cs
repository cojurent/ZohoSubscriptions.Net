using System.Net.Http;

namespace ZohoSubscriptions.Net.Requests {
    public class DeleteZohoPayment : ZohoSubscriptionsRequest<ZohoResponseMessage> {

        public DeleteZohoPayment(string paymentId)
            : base($"payments/{paymentId}", HttpMethod.Delete) {
        }
    }
}