using Newtonsoft.Json;
using RestSharp;
using OsuAPIv2.Models;
using OsuAPIv2.Beatmaps;
using static OsuAPIv2.Constants;

namespace OsuAPIv2
{
    public partial class OsuAPI
    {
       public async Task<BeatmapsLookUp.BeatMapsLookUp> FindBeatmap(string id="", string checksum="", string filename="")
       {
           var request = new RestRequest(BEATMAP_LOOKUP, Method.Get);
           if (id != "") request.AddQueryParameter("id", id);
           if (checksum != "") request.AddQueryParameter("checksum", checksum);
           if (filename != "") request.AddQueryParameter("filename", filename);
           if (id == "" && checksum == "" && filename == "") throw new OsuAPIException("id, checksum, or filename must be specified");
           var response = await _client.ExecuteGetAsync(request);
           var content = response.Content;
           if (!response.IsSuccessful) throw new OsuAPIException(response.ErrorMessage + response.StatusCode);
           return JsonConvert.DeserializeObject<BeatmapsLookUp.BeatMapsLookUp>(content);
        }

        public async Task<BeatMapsScores.BeatmapScores> GetBeatmapScores(string beatmapId /*,GameModes? modes = null*/)
        {
            var request = new RestRequest(BEATMAP_SCORES, Method.Get);
            request.AddUrlSegment("beatmap", beatmapId ?? throw new ArgumentNullException(nameof(beatmapId)));
            //if (!modes.Equals("")) request.AddParameter("mode", modes.ToString());
            var response = await _client.ExecuteAsync(request);
            if (!response.IsSuccessful) throw new OsuAPIException($"Make sure your the User ID and the Beatmap ID are correct!\n {response.ErrorMessage}");
            return JsonConvert.DeserializeObject<BeatMapsScores.BeatmapScores>(response.Content);
        }
        
        public async Task<UserBeatmapScore.UserBeatmapScores> GetUserBeatmapScores(string beatmapId, string userId,string all="/all", GameModes? modes=null)
        {
            var request = new RestRequest(string.IsNullOrEmpty(all) ? USER_BEATMAP_SCORE : USER_BEATMAP_SCORE + all, Method.Get);
            request.AddUrlSegment("beatmap", beatmapId ?? throw new ArgumentNullException(nameof(beatmapId)));
            request.AddUrlSegment("user", userId ?? throw new ArgumentNullException(nameof(userId)));
            if (modes != null) request.AddQueryParameter("mode", modes.ToString());
            var response = await _client.ExecuteGetAsync(request);
            if (!response.IsSuccessful) throw new OsuAPIException($"Make sure your the User ID and the Beatmap ID are correct!\n {response.ErrorMessage}");
            return JsonConvert.DeserializeObject<UserBeatmapScore.UserBeatmapScores>(response.Content);
        }

        public async Task<Beatmap.BeatmapRoot> GetBeatMap(string beatmapId)
        {
            var request = new RestRequest(BEATMAP, Method.Get);
            request.AddUrlSegment("beatmap", beatmapId ?? throw new ArgumentNullException(nameof(beatmapId)));
            var response = await _client.ExecuteGetAsync(request);
            if (!response.IsSuccessful) throw new OsuAPIException($"Make sure your the Beatmap ID is correct!\n {response.ErrorMessage}");
            return JsonConvert.DeserializeObject<Beatmap.BeatmapRoot>(response.Content);
        }

        public async Task<BeatmapAttributes.Root> GetBeatmapAttribute(string beatmapID)
        {
            var request = new RestRequest(BEATMAP_ATTRIBUTE, Method.Post);
            request.AddUrlSegment("beatmap", beatmapID ?? throw new ArgumentNullException(nameof(beatmapID)));
            var response = await _client.ExecutePostAsync(request);
            if (!response.IsSuccessful) throw new OsuAPIException($"Make sure your the Beatmap ID is correct!\n {response.ErrorMessage}");
            return JsonConvert.DeserializeObject<BeatmapAttributes.Root>(response.Content);
        }
    }
}
