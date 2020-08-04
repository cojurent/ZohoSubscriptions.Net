using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {
    public class CreateZohoPayment : ZohoSubscriptionsRequest<ZohoResponseMessage> {
        
        public CreateZohoPayment() : base("payments", HttpMethod.Post) {
        }

        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        [JsonPropertyName("customer_id")]
        public string CustomerId { get; set; }

        [JsonPropertyName("payment_mode")]
        public string PaymentMode { get; set; }

        [JsonPropertyName("amount")]
        public float Amount { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("reference_number")]
        public string ReferenceNumber { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("exchange_rate")]
        public float ExchangeRate { get; set; }

        [JsonPropertyName("bank_charges")]
        public float BankCharges { get; set; }

        [JsonPropertyName("tax_account_id")]
        public string TaxAccountId { get; set; }

        [JsonPropertyName("invoices")]
        public List<ZohoInvoicePayment> Invoices { get; set; }
    }
}