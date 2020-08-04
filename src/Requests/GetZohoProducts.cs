using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {
    public class GetZohoProducts : ZohoSubscriptionsRequest<GetZohoProducts.Response> {
        
        public GetZohoProducts() : base("products", HttpMethod.Get) {
        }
        
        public class Response : ZohoResponseMessage {

            [JsonPropertyName("product")]
            public List<ZohoProduct> Products { get; set; }
        }
    }
}