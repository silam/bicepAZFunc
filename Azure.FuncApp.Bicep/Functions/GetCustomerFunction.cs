using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http; 

namespace Azure.App.Bicep.Functions
{
    public class GetCustomerFunction
    {
        [FunctionName(nameof(GetCustomerFunction))]
        public async Task<IActionResult> GetCustomerAsync([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "customers")]
            HttpRequest request)
        {
            await Task.Delay(TimeSpan.FromSeconds(2));

            return new OkObjectResult("Return Customer OK " + DateTime.Now.ToString());
        }
    }
}