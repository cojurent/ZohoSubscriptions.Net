using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ZohoSubscriptions.Net.Models {
    public class ZohoPlan {

        [JsonPropertyName("plan_code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("interval_unit")]
        public string IntervalUnit { get; set; }

        [JsonPropertyName("price")]
        public float Price { get; set; }

        [JsonPropertyName("recurring_price")]
        public float RecurringPrice { get; set; }

        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }

        [JsonPropertyName("exclude_trial")]
        public bool ExcludeTrial { get; set; }

        [JsonPropertyName("store_markup_description")]
        public string StoreMarkupDescription { get; set; }

        [JsonPropertyName("addons")]
        public List<ZohoPlanAddon> Addons { get; set; }
    }
}