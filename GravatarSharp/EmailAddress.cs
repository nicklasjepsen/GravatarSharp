namespace GravatarSharp
{
    /// <summary>
    ///     Holds information about a users email address
    /// </summary>
    public class EmailAddress
    {
        /// <summary>
        ///     True if this is the users primary email, otherwise false
        /// </summary>
        public bool IsPrimaryEmail { get; set; }

        /// <summary>
        ///     The email address
        /// </summary>
        public string Email { get; set; }
    }
}