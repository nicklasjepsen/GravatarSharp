using Newtonsoft.Json;

namespace GravatarSharp.GravatarModels
{
    internal class Email
    {
        [JsonProperty("primary")]
        public string Primary { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}