using RestSharp;
using static OsuAPIv2.Constants;
namespace OsuAPIv2
{
    public partial class OsuAPI
    {
        private readonly RestClient _client;
        
        public OsuAPI(string token)
        {
            Token = token ?? throw new ArgumentNullException(nameof(token));
            _client = new RestClient(BASE_URL_V2);
            _client.AddDefaultHeader("Authorization", $"Bearer {Token}");
        }
        
        private string Token { get; set; }
    }
}
