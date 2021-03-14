using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace MSB.Payments.User.Management.API
{
    public static class User
    {
        [FunctionName("User")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            var user = new MSB.Payments.Model.UserManagement.User();
            user.FirstName = "John";
            user.LastName = "Public";
            user.Email = "john.public@noterealemail.com";
            user.ID = 1;

            return new OkObjectResult(user);
        }
    }
}
