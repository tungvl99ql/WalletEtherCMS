using System;
using System.Diagnostics;
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

        public static async Task<string> Get(string url,string accesstoken)
        {
            using (var httpClient = new HttpClient())
            {
                Debug.WriteLine("url=>" + url);
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                request.Headers.Add("Authorization", "Bearer " + accesstoken);
                var response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }

        }

        public static async Task<string> Post<T>(string url, string accesstoken, T body)
        {
            using (var httpClient = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Post, url);
                request.Headers.Add("Authorization", "Bearer " + accesstoken);
                var content = new StringContent(JsonConvert.SerializeObject(body), System.Text.Encoding.UTF8, "application/json");
                request.Content = content;
                var response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

    }
}
