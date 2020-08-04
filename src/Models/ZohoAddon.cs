using System.Text.Json.Serialization;

namespace ZohoSubscriptions.Net.Models {
    public class ZohoAddon {

        [JsonPropertyName("addon_code")]
        public string Code { get; set; }
    }
}
