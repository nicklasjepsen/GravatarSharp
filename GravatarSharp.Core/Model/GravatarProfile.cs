using GravatarSharp.Core.Json;

namespace GravatarSharp.Core.Model
{
    public class GravatarProfile
    {
        /// <summary>
        /// The gravatar ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The default image thumb url
        /// </summary>
        public string ImageThumbUrl { get; set; }
        /// <summary>
        /// The hash of the returned profile
        /// </summary>
        public string Hash { get; set; }
        /// <summary>
        /// I have no clue... :)
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// What can this be...?
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// The users current location
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// User provided information about one self
        /// </summary>
        public string About { get; set; }
        /// <summary>
        /// Registered email addresses
        /// </summary>
        public string[] Emails { get; set; }
        /// <summary>
        /// Registered web sites/urls
        /// </summary>
        public string[] Urls { get; set; }

        /// <summary>
        /// The raw json response from gravatar.com
        /// </summary>
        public string JsonRaw { get; set; }

        internal GravatarProfile(Profile jsonProfile, string json)
        {
            if (jsonProfile == null ||
                jsonProfile.entry == null ||
                jsonProfile.entry.Length < 1)
                return;

            JsonRaw = json;

            var entry = jsonProfile.entry[0];
            Id = entry.id;
            ImageThumbUrl = entry.thumbnailUrl;
            Hash = entry.hash;
            UserName = entry.displayName;
            if (entry.name != null)
                FullName = entry.name.formatted;
        }
    }
}
