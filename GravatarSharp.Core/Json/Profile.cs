using Newtonsoft.Json;

namespace GravatarSharp.Core.Json
{
    // ReSharper disable InconsistentNaming
    
    /// <summary>
    /// The Gravatar profile is based on the PoCo schema, see http://portablecontacts.net/draft-spec.html#schema
    /// </summary>
    internal class Profile
    {
        public Entry[] entry { get; set; }
    }

    internal class Entry
    {
        public string id { get; set; }
        public string hash { get; set; }
        public string requestHash { get; set; }
        public string profileUrl { get; set; }
        public string preferredUsername { get; set; }
        public string thumbnailUrl { get; set; }
        public Photo[] photos { get; set; }

        [JsonConverter(typeof(SingleValueArrayConverter<Name>))]
        [JsonProperty(Required = Required.AllowNull)]
        public Name name { get; set; }
        public string displayName { get; set; }
        public string aboutMe { get; set; }
        public string currentLocation { get; set; }
        public Email[] emails { get; set; }
        public Account[] accounts { get; set; }
        public Url[] urls { get; set; }
    }

    internal class Name
    {
        public string givenName { get; set; }
        public string familyName { get; set; }
        public string formatted { get; set; }
    }

    internal class Photo
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    internal class Email
    {
        public string primary { get; set; }
        public string value { get; set; }
    }

    internal class Account
    {
        public string domain { get; set; }
        public string display { get; set; }
        public string url { get; set; }
        public string username { get; set; }
        public string verified { get; set; }
        public string shortname { get; set; }
    }

    internal class Url
    {
        public string value { get; set; }
        public string title { get; set; }
    }

    // ReSharper restore InconsistentNaming
}
