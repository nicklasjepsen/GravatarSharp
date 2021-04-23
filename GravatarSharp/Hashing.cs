using System.Security.Cryptography;
using System.Text;

namespace GravatarSharp
{
    /// <summary>
    /// Used to calculate the hash
    /// </summary>
    public class Hashing
    {
        /// <summary>
        ///     Calculate the hash based on this MSDN post:
        ///     http://blogs.msdn.com/b/csharpfaq/archive/2006/10/09/how-do-i-calculate-a-md5-hash-from-a-string_3f00_.aspx
        /// </summary>
        /// <param name="input">The input to hash</param>
        /// <returns>The hashed and lowered string</returns>
        public static string CalculateMd5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            var sb = new StringBuilder();
            foreach (var t in hash) sb.Append(t.ToString("X2"));
            return sb.ToString().ToLower();
        }
    }
}