using Newtonsoft.Json;

namespace OsuAPIv2.Users
{
    public class UsersRA
    {
        public class Beatmap
        {
            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }
        }

        public class UserRecentActivity
        {
            [JsonProperty("created_at")]
            public DateTime CreatedAt { get; set; }

            [JsonProperty("createdAt")]
            public DateTime CreatedAt_RA { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("scoreRank")]
            public string ScoreRank { get; set; }

            [JsonProperty("rank")]
            public int Rank { get; set; }

            [JsonProperty("mode")]
            public string Mode { get; set; }

            [JsonProperty("beatmap")]
            public Beatmap Beatmap { get; set; }

            [JsonProperty("user")]
            public User User { get; set; }
        }

        public class User
        {
            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }
        }


    }
}
