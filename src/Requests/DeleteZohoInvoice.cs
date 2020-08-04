using System.Net.Http;

namespace ZohoSubscriptions.Net.Requests {
    public class DeleteZohoInvoice : ZohoSubscriptionsRequest<ZohoResponseMessage> {

        public DeleteZohoInvoice(string invoiceId)
            : base($"invoices/{invoiceId}", HttpMethod.Delete) {
        }
    }
}