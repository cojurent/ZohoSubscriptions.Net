using System.Text.Json.Serialization;

namespace ZohoSubscriptions.Net.Requests {

    public class ZohoResponseMessage {

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}