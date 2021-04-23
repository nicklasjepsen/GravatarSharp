using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage.Blob;
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

        [FunctionName("Function1")]
        public async Task Run(
            [QueueTrigger("gravatar-queue", Connection = "StorageConnectionString")] string email,
            [Blob("gravatar-images", Connection = "StorageConnectionString")] CloudBlobContainer outputContainer,
            ILogger log)
        {
            var result = await gravatar.GetProfile(email);

            // You probably don't want to do this in a production scenario as it makes a request against the storage account
            await outputContainer.CreateIfNotExistsAsync();
            var cloudBlockBlob = outputContainer.GetBlockBlobReference(result.Profile.Id);
            await cloudBlockBlob.UploadFromStreamAsync(await new HttpClient().GetStreamAsync(result.Profile.ImageThumbUrl));
        }
    }
}

