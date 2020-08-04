using System.Net.Http;
using ZohoSubscriptions.Net.Models;

namespace ZohoSubscriptions.Net.Requests {
    public class UpdateZohoCustomer : ZohoSubscriptionsRequest<ZohoResponseMessage> {
        
        public UpdateZohoCustomer(ZohoCustomer customer)
            : base("customers/" + customer.Id, HttpMethod.Put) {

            Customer = customer;
        }

        private ZohoCustomer Customer { get; set; }
    }
}