using System.Net.Http.Headers;
using Newtonsoft.Json;
using static OsuAPIv2.Constants;
using System.Text;

namespace OsuAPIv2
{ 
    public partial class OsuAccessToken
    { 
        public async Task<ClientCredentialsData> GetAccessToken(string client_id, string client_secret, string grant_type,string scope)
        {
            // RestSharp is broken, I tried many ways but I still got the same error so I used this instead
            var client = new HttpClient();
            client.BaseAddress = new Uri(BASE_OSU_URL);
            client.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, OAUTH_TOKEN);
            var body = new StringBuilder();
            body.Append("client_id=").Append(client_id);
            body.Append("&client_secret=").Append(client_secret);
            body.Append("&grant_type=").Append(grant_type);
            body.Append("&scope=").Append(scope);
            request.Content = new StringContent(body.ToString(), Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await client.SendAsync(request);
            if (!response.IsSuccessStatusCode)
                throw new OsuAPIException(
                    "Make sure your Client ID and Client Secret are correct. Grant type is `client_credentials` and scope is always `public");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ClientCredentialsData>(content);
            
        }
    }
}

