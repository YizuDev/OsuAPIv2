using Newtonsoft.Json;


namespace OsuAPIv2.Beatmaps
{
    public class UserBeatmapScores
    {
        public class CurrentUserAttributes
        {
            [JsonProperty("pin")]
            public object Pin { get; set; }
        }

        public class Root
        {
            [JsonProperty("scores")]
            public List<Score> Scores { get; set; }
        }

        public class Score
        {
            [JsonProperty("accuracy")]
            public double Accuracy { get; set; }

            [JsonProperty("best_id")]
            public long BestId { get; set; }

            [JsonProperty("created_at")]
            public DateTime CreatedAt { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

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

    }
}
