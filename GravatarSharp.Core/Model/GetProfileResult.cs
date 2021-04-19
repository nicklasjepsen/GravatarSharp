namespace GravatarSharp.Core.Model
{
    /// <summary>
    ///     This result contains a profile and also error details, if relevant
    /// </summary>
    public class GetProfileResult
    {
        /// <summary>
        ///     The profile requested
        /// </summary>
        public GravatarProfile Profile { get; set; }

        /// <summary>
        ///     If an error occurs in the request, here is where the details will be
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}