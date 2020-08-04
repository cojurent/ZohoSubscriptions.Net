using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {

    public class GetZohoCustomerCards : ZohoSubscriptionsRequest<GetZohoCustomerCards.Response> {
        
        public GetZohoCustomerCards(string customerId) : base("customers/" + customerId + "/cards", HttpMethod.Get) {
        }
        
        public class Response : ZohoResponseMessage {

            [JsonPropertyName("cards")]
            public List<ZohoCard> Cards { get; set; }
        }
    }
}