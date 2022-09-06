using Newtonsoft.Json;
using RestSharp;
using OsuAPIv2.Users;
using OsuAPIv2.Models;
using static OsuAPIv2.Constants;

namespace OsuAPIv2
{ 
    public partial class OsuAPI
    {
        public async Task<User.UsersData> GetUser(string userId)
        {
            var request = new RestRequest(USER_DATA, Method.Get);
            request.AddUrlSegment("user", userId);
            var response = await _client.ExecuteGetAsync(request);
            if (!response.IsSuccessful) throw new OsuAPIException($"Make sure User's ID is correct!\n{response.StatusCode}");
            return JsonConvert.DeserializeObject<User.UsersData>(response.Content);
        }

        public async Task<List<UsersRA.UserRecentActivity>> GetUserRecentActivity(string userId)
        {
            var request = new RestRequest(USER_RECENT_ACTIVITY, Method.Get);
            request.AddUrlSegment("user", userId);
            var response = await _client.ExecuteGetAsync(request);
            if (!response.IsSuccessful) throw new OsuAPIException($"Make sure User's ID is correct!\n{response.StatusCode}");
            return JsonConvert.DeserializeObject<List<UsersRA.UserRecentActivity>>(response.Content);
        }

        public async Task<List<UserScore.UserScores>> GetUserScores(string userId, ScoreTypes scoreTypes)
        {
            var request = new RestRequest(USER_SCORES, Method.Get);
            request.AddUrlSegment("user", userId);
            request.AddUrlSegment("type", scoreTypes.ToString());
            var response = await _client.ExecuteGetAsync(request);
            if (!response.IsSuccessful) throw new OsuAPIException($"Make sure User's ID and Score Type is correct!\n{response.StatusCode}");
            return JsonConvert.DeserializeObject<List<UserScore.UserScores>>(response.Content);
        }
    }
}