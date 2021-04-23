using Newtonsoft.Json;

namespace GravatarSharp.GravatarModels
{
    internal class Entry
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("requestHash")]
        public string RequestHash { get; set; }

        [JsonProperty("profileUrl")]
        public string ProfileUrl { get; set; }

        [JsonProperty("preferredUsername")]
        public string PreferredUsername { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("photos")]
        public Photo[] Photos { get; set; }

        [JsonConverter(typeof(SingleValueArrayConverter<Name>))]
        [JsonProperty("name", Required = Required.AllowNull)]
        public Name Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("aboutMe")]
        public string AboutMe { get; set; }

        [JsonProperty("currentLocation")]
        public string CurrentLocation { get; set; }

        [JsonProperty("emails")]
        public Email[] Emails { get; set; }

        [JsonProperty("accounts")]
        public Account[] Accounts { get; set; }

        [JsonProperty("urls")]
        public Url[] Urls { get; set; }
    }
}