using Newtonsoft.Json;

namespace GravatarSharp.GravatarModels
{
    internal class Photo
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}