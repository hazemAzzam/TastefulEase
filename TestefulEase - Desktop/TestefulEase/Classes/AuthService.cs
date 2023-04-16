using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Net;


namespace TestefulEase.Classes
{
    public class AuthService
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public async Task<string> SendPostRequestAsync(string url, Dictionary<string, string> data)
        {
            var requestBody = new FormUrlEncodedContent(data);

            var response = await httpClient.PostAsync(url, requestBody);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            else
            {
                return null;
            }
        }

        public async Task<ApiResponse> SendPostRequest(string url, string data)
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Content = new StringContent(data, Encoding.UTF8, "application/json");

            // Send the request and get the response
            HttpResponseMessage response = await client.SendAsync(request);
            int statusCode = (int)response.StatusCode;
            string responseBody = await response.Content.ReadAsStringAsync();

            return new ApiResponse { StatusCode = statusCode, Content = responseBody };
        }


        public async Task<string> GetRquestAsync(string url)
        {
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode )
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            else
            {
                return null;
            }
        }
    }
}
