﻿namespace GravatarSharp
{
    /// <summary>
    ///     Contains info about a users web sites
    /// </summary>
    public class WebSite
    {
        /// <summary>
        ///     The user provided title of the site/url
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///     The url
        /// </summary>
        public string Url { get; set; }
    }
}