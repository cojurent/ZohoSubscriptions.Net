using System.Text.Json.Serialization;

namespace ZohoSubscriptions.Net.Models {

    public class ZohoInvoicePayment {

        public ZohoInvoicePayment() {
        }

        public ZohoInvoicePayment(string invoiceId, float amount) {
            InvoiceId = invoiceId;
            Amount = amount;
        }

        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }

        [JsonPropertyName("amount_applied")]
        public float Amount { get; set; }
    }
}