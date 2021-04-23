using System;
using System.Net.Http;
using System.Threading.Tasks;
using GravatarSharp.GravatarModels;
using Newtonsoft.Json;

namespace GravatarSharp
{
    /// <summary>
    ///     Get a Gravatar user profile and a Gravatar image url by using this class.
    /// </summary>
    public class GravatarController
    {
        /// <summary>
        /// The user agent used in the HTTP request headers
        /// </summary>
        public string UserAgent =>
            $"GravatarSharp/1.0 ({Environment.OSVersion.Platform}; {Environment.OSVersion.VersionString})";
        private readonly HttpClient httpClient;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpClient">The HttpClient used to make the request to Gravatar.
        /// Microsoft recommends NOT to dispose the HttpClient after every request, so please provide an instance of it.
        /// For instance by using Dependency Injection: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-5.0#typed-clients</param>
        public GravatarController(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        /// <summary>
        ///     Gets the Gravatar profile for the given user/email
        /// </summary>
        /// <param name="email">The email that will be used to request the user profile</param>
        /// <returns>The user profile corresponding to the provided email address</returns>
        public async Task<GetProfileResult> GetProfile(string email)
        {
            var json = await GetStringResponse($"https://en.gravatar.com/{Hashing.CalculateMd5Hash(email)}.json");
            if (string.IsNullOrEmpty(json.ErrorMessage))
                return new GetProfileResult
                {
                    Profile = new GravatarProfile(JsonConvert.DeserializeObject<Profile>(json.Result), json.Result)
                };
            return new GetProfileResult
            {
                ErrorMessage = json.ErrorMessage
            };
        }

        /// <summary>
        ///     Gets the Gravatar image url for the given user/email
        /// </summary>
        /// <param name="email">The email that will be used to request the user image url</param>
        /// <param name="width">The width in pixels. Default is 128</param>
        /// <returns>The image url corresponding to the provided email address</returns>
        public static string GetImageUrl(string email, int width = 128)
        {
            return $"http://www.gravatar.com/avatar/{Hashing.CalculateMd5Hash(email)}?s={width}&d=identicon&r=PG";
        }

        private async Task<HttpStringResponse> GetStringResponse(string uri)
        {
            try
            {
                var response = await httpClient.SendAsync(new HttpRequestMessage
                {
                    RequestUri = new Uri(uri),
                    Headers =
                    {
                        {"User-Agent", UserAgent },
                        {"Accept", "application/json"}
                    }
                });
                return new HttpStringResponse
                {
                    Result = await response.Content.ReadAsStringAsync()
                };
            }
            catch (HttpRequestException httpRequestException)
            {
                return new HttpStringResponse
                {
                    ErrorMessage = httpRequestException.Message
                };
            }
        }

        private class HttpStringResponse
        {
            public string Result { get; set; }
            public string ErrorMessage { get; set; }
        }
    }
}