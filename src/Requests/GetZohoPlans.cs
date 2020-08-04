using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {
    public class GetZohoPlans : ZohoSubscriptionsRequest<GetZohoPlans.Response> {
        
        public GetZohoPlans() : base("plans?filter_by=PlanStatus.ACTIVE", HttpMethod.Get) {
        }
        
        public class Response : ZohoResponseMessage {

            [JsonPropertyName("plans")]
            public List<ZohoPlan> Plans { get; set; }
        }
    }
}