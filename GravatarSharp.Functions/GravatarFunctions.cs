using System.Threading.Tasks;
using GravatarSharp.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GravatarSharp.Functions
{
    public class GravatarFunctions
    {
        private readonly GravatarController gravatar;

        public GravatarFunctions(GravatarController gravatar)
        {
            this.gravatar = gravatar;
        }

        [FunctionName("GetGravatarData")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            string email = req.Query["email"];
            if (string.IsNullOrEmpty(email))
                return new BadRequestObjectResult("The query parameter 'email' is required.");

            var result = await gravatar.GetProfile(email);
            return new OkObjectResult(JsonConvert.SerializeObject(result));
        }
    }
}

