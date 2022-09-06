using Newtonsoft.Json;

namespace OsuAPIv2.Users
{
    public class UserScore
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
            public double Accuracy { get; set; }

            [JsonProperty("ar")]
            public double Ar { get; set; }

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
            public double Cs { get; set; }

            [JsonProperty("deleted_at")]
            public object DeletedAt { get; set; }

            [JsonProperty("drain")]
            public double Drain { get; set; }

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

        public class Beatmapset
        {
            [JsonProperty("artist")]
            public string Artist { get; set; }

            [JsonProperty("artist_unicode")]
            public string ArtistUnicode { get; set; }

            [JsonProperty("covers")]
            public Covers Covers { get; set; }

            [JsonProperty("creator")]
            public string Creator { get; set; }

            [JsonProperty("favourite_count")]
            public int FavouriteCount { get; set; }

            [JsonProperty("hype")]
            public object Hype { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("nsfw")]
            public bool Nsfw { get; set; }

            [JsonProperty("offset")]
            public int Offset { get; set; }

            [JsonProperty("play_count")]
            public int PlayCount { get; set; }

            [JsonProperty("preview_url")]
            public string PreviewUrl { get; set; }

            [JsonProperty("source")]
            public string Source { get; set; }

            [JsonProperty("spotlight")]
            public bool Spotlight { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("title_unicode")]
            public string TitleUnicode { get; set; }

            [JsonProperty("track_id")]
            public int? TrackId { get; set; }

            [JsonProperty("user_id")]
            public int UserId { get; set; }

            [JsonProperty("video")]
            public bool Video { get; set; }
        }

        public class Covers
        {
            [JsonProperty("cover")]
            public string Cover { get; set; }

            [JsonProperty("cover@2x")]
            public string Cover2x { get; set; }

            [JsonProperty("card")]
            public string Card { get; set; }

            [JsonProperty("card@2x")]
            public string Card2x { get; set; }

            [JsonProperty("list")]
            public string List { get; set; }

            [JsonProperty("list@2x")]
            public string List2x { get; set; }

            [JsonProperty("slimcover")]
            public string Slimcover { get; set; }

            [JsonProperty("slimcover@2x")]
            public string Slimcover2x { get; set; }
        }

        public class CurrentUserAttributes
        {
            [JsonProperty("pin")]
            public object Pin { get; set; }
        }

        public class UserScores
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
            public int Score { get; set; }

            [JsonProperty("statistics")]
            public Statistics Statistics { get; set; }

            [JsonProperty("user_id")]
            public int UserId { get; set; }

            [JsonProperty("current_user_attributes")]
            public CurrentUserAttributes CurrentUserAttributes { get; set; }

            [JsonProperty("beatmap")]
            public Beatmap Beatmap { get; set; }

            [JsonProperty("beatmapset")]
            public Beatmapset Beatmapset { get; set; }

            [JsonProperty("user")]
            public User User { get; set; }

            [JsonProperty("weight")]
            public Weight Weight { get; set; }
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
            public DateTime LastVisit { get; set; }

            [JsonProperty("pm_friends_only")]
            public bool PmFriendsOnly { get; set; }

            [JsonProperty("profile_colour")]
            public object ProfileColour { get; set; }

            [JsonProperty("username")]
            public string Username { get; set; }
        }

        public class Weight
        {
            [JsonProperty("percentage")]
            public double Percentage { get; set; }

            [JsonProperty("pp")]
            public double Pp { get; set; }
        }
    }
}
