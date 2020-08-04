using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {

    public class GetZohoInvoices : ZohoSubscriptionsRequest<GetZohoInvoices.Response> {
        
        public GetZohoInvoices() : base("invoices", HttpMethod.Get) {
        }
        
        public class Response : ZohoResponseMessage {

            [JsonPropertyName("invoices")]
            public List<ZohoInvoice> Invoices { get; set; }
        }
    }
}