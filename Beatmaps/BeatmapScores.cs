using Newtonsoft.Json;

namespace OsuAPIv2.Beatmaps
{
    public class BeatMapsScores
    {
        public class Country
        {
            [JsonProperty("code")]
            public string Code { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class Cover
        {
            [JsonProperty("custom_url")]
            public string CustomUrl { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }
        }

        public class CurrentUserAttributes
        {
            [JsonProperty("pin")]
            public object Pin { get; set; }
        }

        public class BeatmapScores
        {
            [JsonProperty("scores")]
            public List<Score> Scores { get; set; }
        }

        public class Score
        {
            [JsonProperty("accuracy")]
            public double Accuracy { get; set; }

            [JsonProperty("best_id")]
            public object BestId { get; set; }

            [JsonProperty("created_at")]
            public DateTime CreatedAt { get; set; }

            [JsonProperty("id")]
            public object Id { get; set; }

            [JsonProperty("max_combo")]
            public int MaxCombo { get; set; }

            [JsonProperty("mode")]
            public string Mode { get; set; }

            [JsonProperty("mode_int")]
            public int ModeInt { get; set; }

            [JsonProperty("mods")]
            public List<string> Mods { get; set; }

            [JsonProperty("passed")]
            public bool Passed { get; set; }

            [JsonProperty("perfect")]
            public bool Perfect { get; set; }

            [JsonProperty("pp")]
            public double Pp { get; set; }

            [JsonProperty("rank")]
            public string Rank { get; set; }

            [JsonProperty("replay")]
            public bool Replay { get; set; }

            [JsonProperty("score")]
            public int TrueScore { get; set; }

            [JsonProperty("statistics")]
            public Statistics Statistics { get; set; }

            [JsonProperty("user_id")]
            public int UserId { get; set; }

            [JsonProperty("current_user_attributes")]
            public CurrentUserAttributes CurrentUserAttributes { get; set; }

            [JsonProperty("user")]
            public User User { get; set; }
        }

        public class Statistics
        {
            [JsonProperty("count_100")]
            public int Count100 { get; set; }

            [JsonProperty("count_300")]
            public int Count300 { get; set; }

            [JsonProperty("count_50")]
            public int Count50 { get; set; }

            [JsonProperty("count_geki")]
            public int CountGeki { get; set; }

            [JsonProperty("count_katu")]
            public int CountKatu { get; set; }

            [JsonProperty("count_miss")]
            public int CountMiss { get; set; }
        }

        public class User
        {
            [JsonProperty("avatar_url")]
            public string AvatarUrl { get; set; }

            [JsonProperty("country_code")]
            public string CountryCode { get; set; }

            [JsonProperty("default_group")]
            public string DefaultGroup { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("is_active")]
            public bool IsActive { get; set; }

            [JsonProperty("is_bot")]
            public bool IsBot { get; set; }

            [JsonProperty("is_deleted")]
            public bool IsDeleted { get; set; }

            [JsonProperty("is_online")]
            public bool IsOnline { get; set; }

            [JsonProperty("is_supporter")]
            public bool IsSupporter { get; set; }

            [JsonProperty("last_visit")]
            public DateTime? LastVisit { get; set; }

            [JsonProperty("pm_friends_only")]
            public bool PmFriendsOnly { get; set; }

            [JsonProperty("profile_colour")]
            public object ProfileColour { get; set; }

            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("country")]
            public Country Country { get; set; }

            [JsonProperty("cover")]
            public Cover Cover { get; set; }
        }

    }
}
