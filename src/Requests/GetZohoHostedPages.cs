using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {

    public class GetZohoHostedPages : ZohoSubscriptionsRequest<GetZohoHostedPages.Response> {
        
        public GetZohoHostedPages() : base("hostedpages", HttpMethod.Get) {
        }
        
        public class Response : ZohoResponseMessage {

            [JsonPropertyName("hosted_pages")]
            public List<ZohoHostedPage> Pages { get; set; }
        }
    }
}