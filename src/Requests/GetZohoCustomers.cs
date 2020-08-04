using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {

    public class GetZohoCustomers : ZohoSubscriptionsRequest<GetZohoCustomers.Response> {
        
        public GetZohoCustomers() : base("customers", HttpMethod.Get) {
        }

        public GetZohoCustomers(string email) : base("customers?email=" + email, HttpMethod.Get) {
        }
        
        public class Response : ZohoResponseMessage {

            [JsonPropertyName("customers")]
            public List<ZohoCustomer> Customers { get; set; }
        }
    }
}