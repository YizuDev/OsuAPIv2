using Newtonsoft.Json;

namespace OsuAPIv2.Beatmaps
{
    public class Beatmaps
    {
        public class Availability
        {
            [JsonProperty("download_disabled")]
            public bool DownloadDisabled { get; set; }

            [JsonProperty("more_information")]
            public object MoreInformation { get; set; }
        }

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
            public int Accuracy { get; set; }

            [JsonProperty("ar")]
            public int Ar { get; set; }

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
            public int Cs { get; set; }

            [JsonProperty("deleted_at")]
            public object DeletedAt { get; set; }

            [JsonProperty("drain")]
            public int Drain { get; set; }

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

            [JsonProperty("beatmapset")]
            public Beatmapset Beatmapset { get; set; }

            [JsonProperty("failtimes")]
            public Failtimes Failtimes { get; set; }

            [JsonProperty("max_combo")]
            public int MaxCombo { get; set; }
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
            public int TrackId { get; set; }

            [JsonProperty("user_id")]
            public int UserId { get; set; }

            [JsonProperty("video")]
            public bool Video { get; set; }

            [JsonProperty("availability")]
            public Availability Availability { get; set; }

            [JsonProperty("bpm")]
            public int Bpm { get; set; }

            [JsonProperty("can_be_hyped")]
            public bool CanBeHyped { get; set; }

            [JsonProperty("discussion_enabled")]
            public bool DiscussionEnabled { get; set; }

            [JsonProperty("discussion_locked")]
            public bool DiscussionLocked { get; set; }

            [JsonProperty("is_scoreable")]
            public bool IsScoreable { get; set; }

            [JsonProperty("last_updated")]
            public DateTime LastUpdated { get; set; }

            [JsonProperty("legacy_thread_url")]
            public string LegacyThreadUrl { get; set; }

            [JsonProperty("nominations_summary")]
            public NominationsSummary NominationsSummary { get; set; }

            [JsonProperty("ranked")]
            public int Ranked { get; set; }

            [JsonProperty("ranked_date")]
            public DateTime RankedDate { get; set; }

            [JsonProperty("storyboard")]
            public bool Storyboard { get; set; }

            [JsonProperty("submitted_date")]
            public DateTime SubmittedDate { get; set; }

            [JsonProperty("tags")]
            public string Tags { get; set; }

            [JsonProperty("ratings")]
            public List<int> Ratings { get; set; }
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

        public class Failtimes
        {
            [JsonProperty("fail")]
            public List<int> Fail { get; set; }

            [JsonProperty("exit")]
            public List<int> Exit { get; set; }
        }

        public class NominationsSummary
        {
            [JsonProperty("current")]
            public int Current { get; set; }

            [JsonProperty("required")]
            public int Required { get; set; }
        }

        public class BeatmapsInfo
        {
            [JsonProperty("beatmaps")]
            public List<Beatmap> Beatmaps { get; set; }
        }        
    }
}
