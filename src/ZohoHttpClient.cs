using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;

namespace ZohoSubscriptions.Net {
    public class ZohoHttpClient : IDisposable {

        public ZohoHttpClient(string authToken, string organizationId) {
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(AuthenticationHeaderName, authToken);
            Client.DefaultRequestHeaders.Add(OrganizationHeaderName, organizationId);
        }

        public void Dispose() {
            Client?.Dispose();
        }

        public async Task<HttpResponseMessage> Put<T>(string path, T request) {
            return await Client.PutAsync(new Uri(path), new StringContent(JsonSerializer.Serialize(request)));
        }

        public async Task<HttpResponseMessage> Delete(string path) {
            return await Client.DeleteAsync(new Uri(path));
        }

        public async Task<HttpResponseMessage> Get(string path) {
            return await Client.GetAsync(new Uri(path));
        }
        
        public async Task<HttpResponseMessage> Post<T>(string path, T request) {
            return await Client.PostAsync(new Uri(path), new StringContent(JsonSerializer.Serialize(request)));
        }

        public async Task<R> Post<T, R>(string path, T request) {
            var response = await Post(path, request);
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<R>(json);
        }
        
        private HttpClient Client { get; set; }

        private const string AuthenticationHeaderName = "Zoho-authtoken";

        private const string OrganizationHeaderName = "X-com-zoho-subscriptions-organizationid";
    }
}