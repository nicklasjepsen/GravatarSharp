using Newtonsoft.Json;

namespace GravatarSharp.Core.Json
{
    /// <summary>
    ///     The Gravatar profile is based on the PoCo schema, see http://portablecontacts.net/draft-spec.html#schema
    /// </summary>
    internal class Profile
    {
        public Entry[] entry { get; set; }
    }

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

    internal class Name
    {
        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("formatted")]
        public string Formatted { get; set; }
    }

    internal class Photo
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    internal class Email
    {
        [JsonProperty("primary")]
        public string Primary { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

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

    internal class Url
    {
        [JsonProperty("value")]
        public string value { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }
    }
}