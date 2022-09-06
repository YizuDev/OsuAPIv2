using Newtonsoft.Json;

namespace OsuAPIv2.Beatmaps
{
    public class BeatmapAttributes
    {
        public class Attributes
        {
            [JsonProperty("star_rating")]
            public double StarRating { get; set; }

            [JsonProperty("max_combo")]
            public int MaxCombo { get; set; }

            [JsonProperty("aim_difficulty")]
            public double AimDifficulty { get; set; }

            [JsonProperty("speed_difficulty")]
            public double SpeedDifficulty { get; set; }

            [JsonProperty("flashlight_difficulty")]
            public int FlashlightDifficulty { get; set; }

            [JsonProperty("slider_factor")]
            public double SliderFactor { get; set; }

            [JsonProperty("approach_rate")]
            public int ApproachRate { get; set; }

            [JsonProperty("overall_difficulty")]
            public int OverallDifficulty { get; set; }
        }

        public class Root
        {
            [JsonProperty("attributes")]
            public Attributes Attributes { get; set; }
        }
    }
}
