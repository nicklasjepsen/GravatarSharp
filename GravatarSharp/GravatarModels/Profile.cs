namespace GravatarSharp.GravatarModels
{
    /// <summary>
    ///     The Gravatar profile is based on the PoCo schema, see http://portablecontacts.net/draft-spec.html#schema
    /// </summary>
    internal class Profile
    {
        public Entry[] entry { get; set; }
    }
}