using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {
    public class CreateZohoInvoice : ZohoSubscriptionsRequest<CreateZohoInvoice.Response> {
        
        public CreateZohoInvoice() : base("invoices", HttpMethod.Post) {
        }
        
        [JsonPropertyName("customer_id")]
        public string CustomerId { get; set; }

        [JsonPropertyName("invoice_date")]
        public string Date { get; set; }

        [JsonPropertyName("due_date")]
        public string DueDate { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("invoice_items")]
        public List<ZohoInvoiceItem> Items { get; set; }
        
        public class Response : ZohoResponseMessage {

            [JsonPropertyName("invoice")]
            public ZohoInvoice Invoice { get; set; }
        }
    }
}