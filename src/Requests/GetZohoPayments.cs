using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {

    public class GetZohoPayments : ZohoSubscriptionsRequest<GetZohoPayments.Response> {
        
        public GetZohoPayments() : base("payments", HttpMethod.Get) {
        }
        
        public class Response : ZohoResponseMessage {

            [JsonPropertyName("payments")]
            public List<ZohoPayment> Payments { get; set; }
        }
    }
}