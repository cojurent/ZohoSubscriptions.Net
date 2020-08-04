using System.Net.Http;

namespace ZohoSubscriptions.Net.Requests {
    public class DeleteZohoCustomer : ZohoSubscriptionsRequest<ZohoResponseMessage> {

        public DeleteZohoCustomer(string customerId)
            : base($"customers/{customerId}", HttpMethod.Delete) {
        }
    }
}