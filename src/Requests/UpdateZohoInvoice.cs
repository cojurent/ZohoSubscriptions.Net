using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {
    public class UpdateZohoInvoice : ZohoSubscriptionsRequest<ZohoResponseMessage> {
        
        public UpdateZohoInvoice(string invoiceId) : base("invoices/" + invoiceId + "/lineitems", HttpMethod.Post) {
        }

        [JsonPropertyName("invoice_items")]
        public List<ZohoInvoiceItem> Items { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}