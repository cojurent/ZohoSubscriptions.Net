using System.Text.Json.Serialization;

namespace ZohoSubscriptions.Net.Models {
    public class ZohoPlanAddon {

        [JsonPropertyName("addon_code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}