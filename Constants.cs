using System.Text;

namespace OsuAPIv2
{
    public static class Constants
    {
        // Beatmap Endpoints
        internal const string BASE_OSU_URL = "https://osu.ppy.sh";
        internal const string BASE_URL_V2 = "https://osu.ppy.sh/api/v2"; // Osu API v2
        internal const string OAUTH_AUTHORISE = "oauth/authorize";
        internal const string OAUTH_TOKEN = "oauth/token";
        internal const string BEATMAP_LOOKUP = "beatmaps/lookup"; // Beatmap lookup
        internal const string USER_BEATMAP_SCORE = "beatmaps/{beatmap}/scores/users/{user}"; // User beatmap score
        internal const string USER_BEATMAP_SCORES = "beatmaps/{beatmap}/scores/{mode}/{user}"; // User Beatmap scores
        internal const string BEATMAP_SCORES = "beatmaps/{beatmap}/scores"; // Beatmap scores
        internal const string BEATMAPS = "beatmaps"; // Beatmaps
        internal const string BEATMAP = "beatmaps/{beatmap}"; // Beatmap
        internal const string BEATMAP_ATTRIBUTE = "beatmaps/{beatmap}/attributes"; // Beatmap Attribute

        // User Endpoints
        internal const string USER_DATA = "users/{user}";
        internal const string USER_KUDOSU = "users/{user}/kudosu"; // User's Kudosu
        internal const string USER_BEATMAPS = "users/{user}/beatmapsets/{type}"; // User's beatmaps
        internal const string USER_RECENT_ACTIVITY = "users/{user}/recent_activity"; // User's Recent Activity
        internal const string USER_SCORES = "users/{user}/scores/{type}"; // User's scores

        // Score types
        internal const string BEST_SCORE = "best";
        internal const string FIRSTS_SOCRE = "first";
        internal const string RECENT_SCORE = "recent";
    }
}