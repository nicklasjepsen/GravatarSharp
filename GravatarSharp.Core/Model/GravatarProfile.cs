using System;
using System.Linq;
using GravatarSharp.Core.Json;

namespace GravatarSharp.Core.Model
{
    /// <summary>
    ///     The gravatar profile converted to a C# class for ease of usage.
    /// </summary>
    public class GravatarProfile
    {
        internal GravatarProfile(Profile jsonProfile, string json)
        {
            if (jsonProfile?.entry == null || jsonProfile.entry.Length < 1)
                return;

            var entry = jsonProfile.entry[0];

            JsonRaw = json;
            Id = entry.Id;
            ImageThumbUrl = entry.ThumbnailUrl;
            Hash = entry.Hash;
            UserName = entry.DisplayName;
            if (entry.Name != null)
                FullName = entry.Name.Formatted;
            Hash = entry.Hash;
            Location = entry.CurrentLocation;
            About = entry.AboutMe;

            if (entry.Emails != null)
                Emails =
                    entry.Emails.Select(e => new EmailAddress
                    {
                        Email = e.Value,
                        IsPrimaryEmail = TryConvertStringToBool(e.Primary)
                    }).ToArray();

            if (entry.Urls != null)
                WebSites = entry.Urls.Select(url => new WebSite
                {
                    Title = url.title,
                    Url = url.value
                }).ToArray();
            //
        }

        /// <summary>
        ///     The gravatar ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     The default image thumb url
        /// </summary>
        public string ImageThumbUrl { get; set; }

        /// <summary>
        ///     The hash of the returned profile
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        ///     The hash of the current profile.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        ///     What can this be...?
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        ///     The users current location
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        ///     User provided information about one self
        /// </summary>
        public string About { get; set; }

        /// <summary>
        ///     Registered email addresses
        /// </summary>
        public EmailAddress[] Emails { get; set; }

        /// <summary>
        ///     Registered web sites/urls
        /// </summary>
        public WebSite[] WebSites { get; set; }

        /// <summary>
        ///     The raw json response from gravatar.com
        /// </summary>
        public string JsonRaw { get; set; }

        private static bool TryConvertStringToBool(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;
            try
            {
                return Convert.ToBoolean(input);
            }
            catch (FormatException)
            {
                return false;
            }
            catch (InvalidCastException)
            {
                return false;
            }
        }
    }
}