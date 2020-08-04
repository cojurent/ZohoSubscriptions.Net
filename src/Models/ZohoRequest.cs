using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ZohoSubscriptions.Net.Requests;

namespace ZohoSubscriptions.Net.Models {
    public abstract class ZohoRequest<R> where R : ZohoResponseMessage {

        protected ZohoRequest(string url, HttpMethod method) {
            Url = url;
            Method = method;
        }

        public async Task<R> RequestAsync(ZohoHttpClient client) {
            var content = await InternalRequestAsync(client);
            return JsonSerializer.Deserialize<R>(content);
        }

        public async Task<T> RequestAsync<T>(ZohoHttpClient client) {
            var content = await InternalRequestAsync(client);
            return JsonSerializer.Deserialize<T>(content);
        }

        private async Task<string> InternalRequestAsync(ZohoHttpClient client) {
            HttpResponseMessage response;

            if(Method == HttpMethod.Post) {
                response = await client.Post(Url, this);
            }
            else if(Method == HttpMethod.Delete) {
                response = await client.Delete(Url);
            }
            else if(Method == HttpMethod.Put) {
                response = await client.Put(Url, this);
            }
            else {
                response = await client.Get(Url);
            }

            return await response.Content.ReadAsStringAsync();
        }

        private string Url { get; set; }

        private HttpMethod Method { get; set; }
    }
}