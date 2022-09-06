using Newtonsoft.Json;

namespace OsuAPIv2.Beatmaps
{
    public class Beatmap
    {
        public class Availability
        {
            [JsonProperty("download disabled")]
            public bool DownloadDisabled { get; set; }

            [JsonProperty("more information")]
            public object MoreInformation { get; set; }
        }

        public class Beatmapset
        {
            [JsonProperty("artist")]
            public string Artist { get; set; }

            [JsonProperty("artist unicode")]
            public string ArtistUnicode { get; set; }

            [JsonProperty("covers")]
            public Covers Covers { get; set; }

            [JsonProperty("creator")]
            public string Creator { get; set; }

            [JsonProperty("favourite count")]
            public int FavouriteCount { get; set; }

            [JsonProperty("hype")]
            public object Hype { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("nsfw")]
            public bool Nsfw { get; set; }

            [JsonProperty("offset")]
            public int Offset { get; set; }

            [JsonProperty("play count")]
            public int PlayCount { get; set; }

            [JsonProperty("preview url")]
            public string PreviewUrl { get; set; }

            [JsonProperty("source")]
            public string Source { get; set; }

            [JsonProperty("spotlight")]
            public bool Spotlight { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("title unicode")]
            public string TitleUnicode { get; set; }

            [JsonProperty("track id")]
            public string TrackId { get; set; }

            [JsonProperty("user id")]
            public int UserId { get; set; }

            [JsonProperty("video")]
            public bool Video { get; set; }

            [JsonProperty("availability")]
            public Availability Availability { get; set; }

            [JsonProperty("bpm")]
            public int Bpm { get; set; }

            [JsonProperty("can be hyped")]
            public bool CanBeHyped { get; set; }

            [JsonProperty("discussion enabled")]
            public bool DiscussionEnabled { get; set; }

            [JsonProperty("discussion locked")]
            public bool DiscussionLocked { get; set; }

            [JsonProperty("is scoreable")]
            public bool IsScoreable { get; set; }

            [JsonProperty("last updated")]
            public DateTime LastUpdated { get; set; }

            [JsonProperty("legacy thread url")]
            public string LegacyThreadUrl { get; set; }

            [JsonProperty("nominations summary")]
            public NominationsSummary NominationsSummary { get; set; }

            [JsonProperty("ranked")]
            public int Ranked { get; set; }

            [JsonProperty("ranked date")]
            public DateTime RankedDate { get; set; }

            [JsonProperty("storyboard")]
            public bool Storyboard { get; set; }

            [JsonProperty("submitted date")]
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

        public class BeatmapRoot
        {
            [JsonProperty("beatmapset id")]
            public int BeatmapsetId { get; set; }

            [JsonProperty("difficulty rating")]
            public double DifficultyRating { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("mode")]
            public string Mode { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("total length")]
            public int TotalLength { get; set; }

            [JsonProperty("user id")]
            public int UserId { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("accuracy")]
            public float Accuracy { get; set; }

            [JsonProperty("ar")]
            public float Ar { get; set; }

            [JsonProperty("bpm")]
            public float? Bpm { get; set; }

            [JsonProperty("convert")]
            public bool Convert { get; set; }

            [JsonProperty("count circles")]
            public int CountCircles { get; set; }

            [JsonProperty("count sliders")]
            public int CountSliders { get; set; }

            [JsonProperty("count spinners")]
            public int CountSpinners { get; set; }

            [JsonProperty("cs")]
            public float Cs { get; set; }

            [JsonProperty("deleted at")]
            public object DeletedAt { get; set; }

            [JsonProperty("drain")]
            public float Drain { get; set; }

            [JsonProperty("hit length")]
            public int HitLength { get; set; }

            [JsonProperty("is scoreable")]
            public bool IsScoreable { get; set; }

            [JsonProperty("last updated")]
            public DateTime LastUpdated { get; set; }

            [JsonProperty("mode int")]
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

            [JsonProperty("max combo")]
            public int MaxCombo { get; set; }
        }
    }
}
