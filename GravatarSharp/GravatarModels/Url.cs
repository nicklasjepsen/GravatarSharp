using Newtonsoft.Json;

namespace GravatarSharp.GravatarModels
{
    internal class Url
    {
        [JsonProperty("value")]
        public string value { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }
    }
}