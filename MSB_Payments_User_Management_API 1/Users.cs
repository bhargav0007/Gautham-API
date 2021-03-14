using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MSB.Payments.User.Management.API
{
    public static class Users
    {
        [FunctionName("Users")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            var list = new List<MSB.Payments.Model.UserManagement.User>();
            for (int i=1;i<=100;i++)
            {
                var user = new MSB.Payments.Model.UserManagement.User();
                user.FirstName = "John"+i;
                user.LastName = "Public"+i;
                user.Email = "john.public"+i+"@noterealemail.com";
                user.ID = i;

                list.Add(user);
            }

            return new OkObjectResult(list);
        }
    }
}
