using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;

namespace Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations
{
    /// <summary>
    /// This represents the environment variable settings entity for OpenAPI document.
    /// </summary>
    public class OpenApiSettings
    {
        /// <summary>
        /// Gets the name of the collection of the environment variables for OpenAPI.
        /// </summary>
        public const string Name = "OpenApi";

        /// <summary>
        /// Gets or sets the OpenAPI spec version.
        /// </summary>
        public virtual OpenApiVersionType Version { get; set; }

        /// <summary>
        /// Gets or sets the OpenAPI document version.
        /// </summary>
        public virtual string DocVersion { get; set; }

        /// <summary>
        /// Gets or sets the OpenAPI document title.
        /// </summary>
        public virtual string DocTitle { get; set; }

        /// <summary>
        /// Gets or sets the OpenAPI document description.
        /// </summary>
        public virtual string DocDescription { get; set; }

        /// <summary>
        /// Gets or sets the comma delimited host names.
        /// </summary>
        public virtual string HostNames { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to exclude the requesting host or not.
        /// </summary>
        public virtual bool ExcludeRequestingHost { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to force the HTTPS connection or not.
        /// </summary>
        public virtual bool ForceHttps { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to force the HTTP connection or not.
        /// </summary>
        public virtual bool ForceHttp { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to hide the Swagger UI page or not.
        /// </summary>
        public virtual bool HideSwaggerUI { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to hide the OpenAPI document pages or not.
        /// </summary>
        public virtual bool HideDocument { get; set; }

        /// <summary>
        /// Gets or sets the API key to access to OpenAPI document.
        /// </summary>
        public virtual string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="OpenApiAuthLevelSettings"/> object.
        /// </summary>
        public virtual OpenApiAuthLevelSettings AuthLevel { get; set; } = new OpenApiAuthLevelSettings();

        /// <summary>
        /// Gets or sets the backend URL for Azure Functions Proxy.
        /// </summary>
        public virtual string BackendProxyUrl { get; set; }
    }
}
