using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CMSWallet.Models
{
    public static class CallAPI
    {
        public static async Task<string> PostAsync<T>(string url, T request)
        {
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(request), System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
