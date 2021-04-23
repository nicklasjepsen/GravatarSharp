using Newtonsoft.Json;

namespace GravatarSharp.GravatarModels
{
    internal class Account
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("verified")]
        public string Verified { get; set; }

        [JsonProperty("shortname")]
        public string ShortName { get; set; }
    }
}