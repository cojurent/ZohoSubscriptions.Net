using System.Text.Json.Serialization;

namespace ZohoSubscriptions.Net.Models {

    public class ZohoCustomField {

        public ZohoCustomField() {
        }

        public ZohoCustomField(string label, string value) {
            Label = label;
            Value = value;
        }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}