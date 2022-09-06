using Newtonsoft.Json;

namespace OsuAPIv2.Beatmaps
{
    public class UserBeatmapScore
    {
        public class Beatmap
        {
            [JsonProperty("beatmapset_id")]
            public int BeatmapsetId { get; set; }

            [JsonProperty("difficulty_rating")]
            public double DifficultyRating { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("mode")]
            public string Mode { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("total_length")]
            public int TotalLength { get; set; }

            [JsonProperty("user_id")]
            public int UserId { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("accuracy")]
            public long Accuracy { get; set; }

            [JsonProperty("ar")]
            public long Ar { get; set; }

            [JsonProperty("bpm")]
            public int Bpm { get; set; }

            [JsonProperty("convert")]
            public bool Convert { get; set; }

            [JsonProperty("count_circles")]
            public int CountCircles { get; set; }

            [JsonProperty("count_sliders")]
            public int CountSliders { get; set; }

            [JsonProperty("count_spinners")]
            public int CountSpinners { get; set; }

            [JsonProperty("cs")]
            public long Cs { get; set; }

            [JsonProperty("deleted_at")]
            public object DeletedAt { get; set; }

            [JsonProperty("drain")]
            public long Drain { get; set; }

            [JsonProperty("hit_length")]
            public int HitLength { get; set; }

            [JsonProperty("is_scoreable")]
            public bool IsScoreable { get; set; }

            [JsonProperty("last_updated")]
            public DateTime LastUpdated { get; set; }

            [JsonProperty("mode_int")]
            public int ModeInt { get; set; }

            [JsonProperty("passcount")]
            public int Passcount { get; set; }

            [JsonProperty("playcount")]
            public int Playcount { get; set; }

            [JsonProperty("ranked")]
            public int Ranked { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("checksum")]
            public string Checksum { get; set; }
        }

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
            public object Id { get; set; }
        }

        public class CurrentUserAttributes
        {
            [JsonProperty("pin")]
            public object Pin { get; set; }
        }

        public class UserBeatmapScores
        {
            [JsonProperty("position")]
            public int Position { get; set; }

            [JsonProperty("score")]
            public Score Score { get; set; }
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

            [JsonProperty("beatmap")]
            public Beatmap Beatmap { get; set; }

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
            public object LastVisit { get; set; }

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
