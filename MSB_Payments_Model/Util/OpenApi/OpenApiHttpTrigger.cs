#if !NET461
using System.Net;
using System.Threading.Tasks;
using Aliencube.AzureFunctions.Extensions.OpenApi.Core.Attributes;
using Aliencube.AzureFunctions.Extensions.OpenApi.Core.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace MSB.Core.Util.OpenApi
{
    /// <summary>
    /// This represents the HTTP trigger entity for Open API documents.
    /// </summary>
    public  class OpenApiHttpTrigger
    {
        private const string V2 = "v2";
        private const string V3 = "v3";
        private const string JSON = "json";
        private const string YAML = "yaml";

        private readonly  IOpenApiHttpTriggerContext context = new OpenApiHttpTriggerContext();

        /// <summary>
        /// Invokes the HTTP trigger endpoint to get Open API document.
        /// </summary>
        /// <param name="req"><see cref="HttpRequest"/> instance.</param>
        /// <param name="extension">File extension representing the document format. This MUST be either "json" or "yaml".</param>
        /// <param name="log"><see cref="ILogger"/> instance.</param>
        /// <returns>Open API document in a format of either JSON or YAML.</returns>
        [FunctionName(nameof(OpenApiHttpTrigger.RenderSwaggerDocument))]
        [OpenApiIgnore]
        public  async Task<IActionResult> RenderSwaggerDocument(
            [HttpTrigger(AuthorizationLevel.Function, "GET", Route = "swagger.{extension}")] HttpRequest req,
            string extension,
            ILogger log)
        {
            log.LogInformation($"swagger.{extension} was requested.");

            var result = await context.Document
                                      .InitialiseDocument()
                                      .AddMetadata(context.OpenApiInfo)
                                      .AddServer(req, context.HttpSettings.RoutePrefix)
                                      .AddNamingStrategy(context.NamingStrategy)
                                      .AddVisitors(context.GetVisitorCollection())
                                      .Build(context.GetExecutingAssembly())
                                      .RenderAsync(context.GetOpenApiSpecVersion(V2), context.GetOpenApiFormat(extension))
                                      .ConfigureAwait(false);

            var content = new ContentResult()
            {
                Content = result,
                ContentType = context.GetOpenApiFormat(extension).GetContentType(),
                StatusCode = (int)HttpStatusCode.OK
            };

            return content;
        }

        /// <summary>
        /// Invokes the HTTP trigger endpoint to get Open API document.
        /// </summary>
        /// <param name="req"><see cref="HttpRequest"/> instance.</param>
        /// <param name="version">Open API document spec version. This MUST be either "v2" or "v3".</param>
        /// <param name="extension">File extension representing the document format. This MUST be either "json" or "yaml".</param>
        /// <param name="log"><see cref="ILogger"/> instance.</param>
        /// <returns>Open API document in a format of either JSON or YAML.</returns>
        [FunctionName(nameof(OpenApiHttpTrigger.RenderOpenApiDocument))]
        [OpenApiIgnore]
        public  async Task<IActionResult> RenderOpenApiDocument(
            [HttpTrigger(AuthorizationLevel.Function, "GET", Route = "openapi/{version}.{extension}")] HttpRequest req,
            string version,
            string extension,
            ILogger log)
        {
            log.LogInformation($"{version}.{extension} was requested.");

            var result = await context.Document
                                      .InitialiseDocument()
                                      .AddMetadata(context.OpenApiInfo)
                                      .AddServer(req, context.HttpSettings.RoutePrefix)
                                      .AddNamingStrategy(context.NamingStrategy)
                                      .AddVisitors(context.GetVisitorCollection())
                                      .Build(context.GetExecutingAssembly())
                                      .RenderAsync(context.GetOpenApiSpecVersion(version), context.GetOpenApiFormat(extension))
                                      .ConfigureAwait(false);

            var content = new ContentResult()
            {
                Content = result,
                ContentType = context.GetOpenApiFormat(extension).GetContentType(),
                StatusCode = (int)HttpStatusCode.OK
            };

            return content;
        }

        /// <summary>
        /// Invokes the HTTP trigger endpoint to render Swagger UI in HTML.
        /// </summary>
        /// <param name="req"><see cref="HttpRequest"/> instance.</param>
        /// <param name="log"><see cref="ILogger"/> instance.</param>
        /// <returns>Swagger UI in HTML.</returns>
        [FunctionName(nameof(OpenApiHttpTrigger.RenderSwaggerUI))]
        [OpenApiIgnore]
        public  async Task<IActionResult> RenderSwaggerUI(
            [HttpTrigger(AuthorizationLevel.Function, "GET", Route = "swagger/ui")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation($"SwaggerUI page was requested.");

            var result = await context.SwaggerUI
                                      .AddMetadata(context.OpenApiInfo)
                                      .AddServer(req, context.HttpSettings.RoutePrefix)
                                      .BuildAsync()
                                      .RenderAsync("swagger.json", context.GetSwaggerAuthKey())
                                      .ConfigureAwait(false);

            var content = new ContentResult()
            {
                Content = result,
                ContentType = "text/html",
                StatusCode = (int)HttpStatusCode.OK
            };

            return content;
        }
    }
}
#endif
